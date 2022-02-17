using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.API.Controllers.AS
{
    [ApiController]
    [Route("api/AS/[controller]")]

    public class VendedorController:ControllerBase
    {
        private readonly StatusERPDBContext _context;

        public VendedorController(StatusERPDBContext context)
        {
            _context = context;
        }
        [HttpGet]   
        //filter =""
        //page =1||2
        //rows =10||10
        public async Task< ActionResult<BaseResponseGeneric< ICollection<Vendedor>>>> Get(
            string? filter,
            int page,
            int rows ,
            int conjunto)
        {

            var response = new BaseResponseGeneric< ICollection<Vendedor>>();

            try
            {
                var query = await _context.Set<Vendedor>()
                .Where(p => p.Nombre.Contains(filter) && p.Activo && p.ConjuntoId.Equals(conjunto))
                .OrderBy(p => p.Nombre)
                .Skip((page - 1) * rows)
                .Take(rows)
                .ToListAsync();
                response.Result = query;
                response.Success = true;
            }
            catch (Exception ex)
            {

               response.Errors.Add(ex.Message);
            }
           
            return Ok(response);

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric <Vendedor>>> Get(int id)
        {
            var response = new BaseResponseGeneric<Vendedor>();
            try
            {
                var entity = await _context.Vendedores.FindAsync(id);
                if (entity == null)
                {
                    response.Errors.Add("No se Encontro el Vendedor");
                    return NotFound(response);
                };

                response.Result = entity;
                response.Success = true;    

            }
            catch (Exception ex)
            {

                response.Errors.Add(ex.Message);
            }
          


            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult> Post(DtoVendedor request)
        {
            var entity = new Vendedor
            {
                CodVendedor = request.CodVendedor,
                Nombre = request.Nombre,
                Email=request.Email,
                Activo=true,
                ConjuntoId =request.ConjutoId,
                Updateby = "SA",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Createby = "SA",
                
            };
            _context.Vendedores.Add(entity);
            await _context.SaveChangesAsync();

            HttpContext.Response.Headers.Add("location", $"/api/AS/vendedor/{entity.Id}");
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoVendedor request)
        {
            var entity = await _context.Vendedores.FindAsync(id);
            if(entity == null) return NotFound();
            entity.Nombre = request.Nombre;
            entity.Email = request.Email;
            entity.ConjuntoId = request.ConjutoId;
            entity.CodVendedor=request.CodVendedor;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new {Id=id});
        }
    }
}
