using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Interfaces.AS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registro la dependencia (Inyeccion de Dependencia)
builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
builder.Services.AddScoped<IVendedorService, VendedorService>();



builder.Services.AddControllers();


builder.Services.AddDbContext<StatusERPDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();

