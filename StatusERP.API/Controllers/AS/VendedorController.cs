using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess;
using StatusERP.Dto.Request.AS;
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
        public async Task< ActionResult<ICollection<Vendedor>>> Get()
        {
            return Ok(await _context.Vendedores.ToListAsync());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Vendedor>> Get(int id)
        {
            var entity= await _context.Vendedores.FindAsync(id);
            if (entity == null) return NotFound();


            return Ok(entity);
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
                Createby = "SA"
               
               
                
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
