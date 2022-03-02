using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StatusERP.DataAccess;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Entities;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Implementations.ERPADMIN;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Services.Interfaces.ERPADMIN;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(options =>
{
    options.AddMaps(typeof(Vendedor));
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


app.MapControllers();
app.Run();

