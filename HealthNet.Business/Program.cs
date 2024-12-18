using BDManager.DAL.Entities;
using HealthNet.Business.Infrastructure;
using HealthNet.DAL;
using HealthNet.DAL.Repositories.Abstraction;
using HealthNet.DAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using HealthNet.DAL.Entities;
using HealthNet.BL.Services.IServices;
using HealthNet.BL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HealthNetContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HealthNetConnectionString")));


builder.Services.AddIdentity<SystemUser, Role>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = false;
})
        .AddEntityFrameworkStores<HealthNetContext>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]);
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
    options.Events = new JwtBearerEvents();
    options.Events.OnTokenValidated = async ctx =>
    {
        var username = ctx.Principal.GetUsername();

        var db = ctx.HttpContext.RequestServices.GetRequiredService<HealthNetContext>();

        var permissons = await db.Users.Where(u => u.UserName == username).Select(u => u.Permissions).FirstOrDefaultAsync();
        var claims = permissons?.Select(p => new Claim(p.Name, "")) ?? new List<Claim>();

        ctx.Principal.AddIdentity(new ClaimsIdentity(claims));
    };
});

builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEarningRepository, EarningRepository>();
builder.Services.AddScoped<IOperationRepository, OperationRepository>();
//builder.Services.AddTransient<IRepository<Appointment>, BaseRepository<Appointment>>();
//builder.Services.AddTransient<IRepository<Patient>, BaseRepository<Patient>>();
//builder.Services.AddTransient<IRepository<Department>, BaseRepository<Department>>();



builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEarningService, EarningService>();
builder.Services.AddScoped<IOperationService, OperationService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
