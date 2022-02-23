using Microsoft.AspNetCore.Identity;
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


builder.Services.AddSqlServer<StatusERPDBContext>(builder.Configuration.GetConnectionString("Default"));
builder.Services.AddIdentity<StatusERPUserIdentity, IdentityRole>(setup =>
{
    setup.Password.RequireNonAlphanumeric = false;
    setup.Password.RequiredUniqueChars = 0;
    setup.Password.RequireUppercase = false;
    setup.Password.RequireLowercase = false;
    setup.Password.RequireDigit = false;
    setup.Password.RequiredLength = 8;
    setup.Lockout = new LockoutOptions()
    {
        MaxFailedAccessAttempts = 2,
        AllowedForNewUsers = false,
        DefaultLockoutTimeSpan = new TimeSpan(0, 0, 40)
    };
    setup.User.RequireUniqueEmail = true;
    setup.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<StatusERPDBContext>()
.AddDefaultTokenProviders();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();
app.Run();

