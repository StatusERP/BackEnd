using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StatusERP.DataAccess;
using StatusERP.Entities;
using System.Text;


using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Interfaces.AS;

using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Services.Implementations.CG;
using StatusERP.Services.Interfaces.CG;

using StatusERP.Services.Interfaces.CI;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.Services.Implementations.CI;
using StatusERP.Services.Profile.AS;

using StatusERP.DataAccess.Repositories.ERPADMIN;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Services.Implementations.ERPADMIN;
using StatusERP.Services.Interfaces.ERPADMIN;

using StatusERP.DataAccess.Repositories.FA;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Services.Implementations.FA;
using StatusERP.Services.Interfaces.FA;



var builder = WebApplication.CreateBuilder(args);

var corsConfiguration = "StatusERPApi";
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(setup =>
{
    setup.AddPolicy(corsConfiguration, x =>
    {
        x.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(options =>
{
    options.AddProfile(new AutoMapperProfileBodega());
   // options.AddMaps(typeof(Concert));
   // options.AddProfile<SaleProfile>();
});


builder.Services.Configure<AppSettings>(builder.Configuration);

//Registro la dependencia (Inyeccion de Dependencia)
builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
builder.Services.AddScoped<IVendedorService, VendedorService>();
builder.Services.AddScoped<ICobradorRepository, CobradorRepository>();
builder.Services.AddScoped<ICobradorService, CobradorService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISucursalesRepository, SucursalesRepository>();
builder.Services.AddScoped<ISucursalService, SucursalService>();
builder.Services.AddScoped<IZonaRepository, ZonaRepository>();
builder.Services.AddScoped<IZonaService, ZonaService>();
builder.Services.AddScoped<IRutaRepository, RutaRepository>();
builder.Services.AddScoped<IRutaService, RutaService>();
builder.Services.AddScoped<IDocTributarioRepository, DocTributarioRepository>();
builder.Services.AddScoped<IDocTributarioService, DocTributarioService>();
builder.Services.AddScoped<IEntidadFinacieraRepository, EntidadFinacieraRepository>();
builder.Services.AddScoped<IEntidadFinacieraService, EntidadFinacieraService>();
builder.Services.AddScoped<IConsecutivoGlobalRepository, ConsecutivoGlobalRepository>();
builder.Services.AddScoped<IConsecutivoGlobalService, ConsecutivoGlobalService>();
builder.Services.AddScoped<IConsecutivoUsuarioRepository, ConsecutivoUsuarioRepository>();
builder.Services.AddScoped<IConsecutivoUsuarioService, ConsecutivoUsuarioService>();
builder.Services.AddScoped<IDivGeografica1Repository, DivGeografica1Repository>();
builder.Services.AddScoped<IDivGeografica1Service, DivGeografica1Service>();
builder.Services.AddScoped<IDivGeografica2Repository, DivGeografica2Repository>();
builder.Services.AddScoped<IDivGeografica2Service, DivGeografica2Service>();
builder.Services.AddScoped<IMembresiaRepository, MembresiaRepository>();
builder.Services.AddScoped<IMenbresiaService, MenbresiaService>();
builder.Services.AddScoped<IAccionRepository, AccionRepository>();
builder.Services.AddScoped<IAccionService, AccionService>();
builder.Services.AddScoped<IParentescoRepository, ParentescoRepository>();
builder.Services.AddScoped<IParentescoService, ParentescoService>();
builder.Services.AddScoped<IModuloInstaladoRepository, ModuloInstaladoRepository>();
builder.Services.AddScoped<IModuloInstaladoService, ModuloInstaladoService>();
builder.Services.AddScoped<IGlobalesAsRepository, GlobalesASRepository>();
builder.Services.AddScoped<IGlobalesASService, GlobalesASService>();
builder.Services.AddScoped<ILocalizacionesRepository, LocalizacionesRepository>();
builder.Services.AddScoped<ILocalizacionesService, LocalizacionesService>();
builder.Services.AddScoped<IMonedaRepository, MonedaRepository>();
builder.Services.AddScoped<IMonedaService, MonedaService>();

builder.Services.AddScoped<IPeriodosContableRepository, PeriodoContableRepository>();
builder.Services.AddScoped<IPeriodoContableService,PeriodoContableService>();
builder.Services.AddScoped<ITipoCambioRepository, TipoCambioRepository>();
builder.Services.AddScoped<ITipoCambioService, TipoCambioService>();
builder.Services.AddScoped<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddScoped<IUnidadMedidaService, UnidadMedidaService>();
builder.Services.AddScoped<IUsuarioBodegaRepository, UsuarioBodegaRepository>();
builder.Services.AddScoped<IUsuarioBodegaService, UsuarioBodegaService>();


// Entidades Módulo AS

builder.Services.AddScoped<IBodegaRepository, BodegaRepository>();
builder.Services.AddScoped<IBodegaService, BodegaService>();

builder.Services.AddScoped<ICategoriaClienteRepository, CategoriaClienteRepository>();
builder.Services.AddScoped<ICategoriaClienteService, CategoriaClienteService>();

builder.Services.AddScoped<ICategoriaProveedorRepository, CategoriaProveedorRepository>();
builder.Services.AddScoped<ICategoriaProveedorService, CategoriaProveedorService>();

builder.Services.AddScoped<ICondicionPagoRepository, CondicionPagoRepository>();
builder.Services.AddScoped<ICondicionPagoService, CondicionPagoService>();

builder.Services.AddScoped<IDetalleDireccionService, DetalleDireccionService>();
builder.Services.AddScoped<IDetalleDireccionRepository, DetalleDireccionRepository>();

builder.Services.AddScoped<IDireccionService, DireccionService>();
builder.Services.AddScoped<IDireccionRepository, DireccionRepository>();

builder.Services.AddScoped<IImpuestoRepository, ImpuestoRepository>();
builder.Services.AddScoped<IImpuestoService, ImpuestoService>();

builder.Services.AddScoped<IPaisRepository, PaisRepository>();
builder.Services.AddScoped<IPaisService, PaisService>();

builder.Services.AddScoped<IPrivilegioUsuarioRepository, PrivilegoUsuarioRepository>();
builder.Services.AddScoped<IPrivilegioUsuarioService, PrivilegioUsuarioService>();

builder.Services.AddScoped<ITipoCambioRepository, TipoCambioRepository>();
builder.Services.AddScoped<ITipoCambioService, TipoCambioService>();

builder.Services.AddScoped<ITipoImpuestoRepository, TipoImpuestoRepository>();
builder.Services.AddScoped<ITipoImpuestoService, TipoImpuestoService>();



// Entidades Módulo CG


builder.Services.AddScoped<ICentroCuentaRepository, CentroCuentaRepository>();
builder.Services.AddScoped<ICentroCuentaService, CentroCuentaService>();

builder.Services.AddScoped<ICuentaContableService, CuentaContableService>();
builder.Services.AddScoped<ICuentaContableRepository, CuentaContableRepository>();

builder.Services.AddScoped<IPaqueteContableService, PaqueteContableService>();
builder.Services.AddScoped<IPaqueteContableRepository, PaqueteContableRepository>();

builder.Services.AddScoped<ISeccionCuentaService, SeccionCuentaService>();
builder.Services.AddScoped<ISeccionCuentaRepository, SeccionCuentaRepository>();

builder.Services.AddScoped<ITipoPartidaRepository, TipoPartidaRepository>();
builder.Services.AddScoped<ITipoPartidaService, TipoPartidaService>();



// Entidades Módulo CI

builder.Services.AddScoped<IAjusteConfigService, AjusteConfigService>();
builder.Services.AddScoped<IAjusteConfigRepository, AjusteConfigRepository>();

builder.Services.AddScoped<IAjusteSubSubTipoService, AjusteSubSubTipoService>();
builder.Services.AddScoped<IAjusteSubSubTipoRepository, AjusteSubSubTipoRepository>();

builder.Services.AddScoped<IAjusteSubTipoService, AjusteSubTipoService>();
builder.Services.AddScoped<IAjusteSubTipoRepository, AjusteSubTipoRepository>();
   
builder.Services.AddScoped<IArticuloService, ArticuloService>();
builder.Services.AddScoped<IArticuloRepository, ArticuloRepository>();

builder.Services.AddScoped<ICategoriaArticuloService, CategoriaArticuloService>();
builder.Services.AddScoped<ICategoriaArticuloRepository, CategoriaArticuloRepository>();

builder.Services.AddScoped<IClasificacionInvService, ClasificacionInvService>();
builder.Services.AddScoped<IClasificacionInvRepository, ClasificacionInvRepository>();

builder.Services.AddScoped<IConsecutivoInvService, ConsecutivoInvService>();
builder.Services.AddScoped<IConsecutivoInvRepository, ConsecutivoInvRepository>();

builder.Services.AddScoped<IConsecutivoInvUsuarioService, ConsecutivoInvUsuarioService>();
builder.Services.AddScoped<IConsecutivoInvUsuarioRepository, ConsecutivoInvUsuarioRepository>();

builder.Services.AddScoped<IConsInvAjConfigService, ConsInvAjConfigService>();
builder.Services.AddScoped<IConsInvAjConfigRepository, ConsInvAjConfigRepository>();

builder.Services.AddScoped<IDocumentoInvDetService, DocumentoInvDetService>();
builder.Services.AddScoped<IDocumentoInvDetRepository, DocumentoInvDetRepository>();

builder.Services.AddScoped<IDocumentoInvEncService, DocumentoInvEncService>();
builder.Services.AddScoped<IDocumentoInvEncRepository, DocumentoInvEncRepository>();

builder.Services.AddScoped<IExistenciaBodegaService, ExistenciaBodegaService>();
builder.Services.AddScoped<IExistenciaBodegaRepository, ExistenciaBodegaRepository>();

builder.Services.AddScoped<IExistenciaLoteService, ExistenciaLoteService>();
builder.Services.AddScoped<IExistenciaLoteRepository, ExistenciaLoteRepository>();

builder.Services.AddScoped<IGlobalesCIService, GlobalesCIService>();
builder.Services.AddScoped<IGlobalesCIRepository, GlobalesCIRepository>();

builder.Services.AddScoped<IIngresoLoteService, IngresoLoteService>();
builder.Services.AddScoped<IIngresoLoteRepository, IngresoLoteRepository>();

builder.Services.AddScoped<ILoteService, LoteService>();
builder.Services.AddScoped<ILoteRepository, LoteRepository>();

builder.Services.AddScoped<IMovInventarioDetService, MovInventarioDetService>();
builder.Services.AddScoped<IMovInventarioDetRepository, MovInventarioDetRepository>();

builder.Services.AddScoped<IMovInventarioEncService, MovInventarioEncService>();
builder.Services.AddScoped<IMovInventarioEncRepository, MovInventarioEncRepository>();

builder.Services.AddScoped<IPaqueteInvService, PaqueteInvService>();
builder.Services.AddScoped<IPaqueteInvRepository, PaqueteInvRepository>();

builder.Services.AddScoped<ITipoOperacionService, TipoOperacionService>();
builder.Services.AddScoped<ITipoOperacionRepository, TipoOperacionRepository>();

builder.Services.AddScoped<ITipoPagoService, TipoPagoService>();
builder.Services.AddScoped<ITipoPagoRepository, TipoPagoRepository>();

builder.Services.AddScoped<IUsuarioAjusteInvService, UsuarioAjusteInvService>();
builder.Services.AddScoped<IUsuarioAjusteInvRepository, UsuarioAjusteInvRepository>();

// Entidades Módulo FA

//builder.Services.AddScoped<IClienteService, ClienteService>();
//builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IGlobalesFARepository, GlobalesFARepository>();
builder.Services.AddScoped<IGlobalesFAService, GlobalesFAService>();

builder.Services.AddScoped<INivelPrecioRepository, NivelPrecioRepository>();
builder.Services.AddScoped<INivelPrecioService, NivelPrecioService>();


builder.Services.AddControllers();


builder.Services.AddSqlServer<StatusERPDBContext>(builder.Configuration.GetConnectionString("Default"));
builder.Services.AddIdentity<StatusERPUserIdentity, IdentityRole>(setup =>
{
    setup.Password.RequireNonAlphanumeric = false;
    setup.Password.RequiredUniqueChars = 0;
    setup.Password.RequireUppercase = false;
    setup.Password.RequireLowercase = false;
    setup.Password.RequireDigit = false;
    setup.Password.RequiredLength = 8;
    setup.Lockout = new LockoutOptions() {
        MaxFailedAccessAttempts = 5,
        AllowedForNewUsers = false,
        DefaultLockoutTimeSpan = new TimeSpan(0, 0, 40)
    };
    setup.User.RequireUniqueEmail = true;
    setup.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<StatusERPDBContext>()
.AddDefaultTokenProviders();

var key = Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("Jwt:Signinkey"));

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
//Habilitamos el Cors 
app.UseCors(corsConfiguration);


app.MapControllers();
app.Run();

