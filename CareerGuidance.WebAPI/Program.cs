using CareerGuidance.BussinessLogic.Business;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.Validation;
using CareerGuidance.Data;
using CareerGuidance.Data.Interceptors;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Mapper;
using CareerGuidance.Setting;
using CareerGuidance.Validation.Service;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var setting = EnviromentSetting.Instance;
var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

builder.Services.AddHttpContextAccessor(); 
builder.Services.AddDbContext<CareerGuidanceDBContext>();
// Add services to the container.
builder.Services.AddTransient<IDataAccessFacade, DataAccessFacade>();
builder.Services.AddTransient<IAuthBusiness, AuthBusiness>();
builder.Services.AddTransient<IValidationService, ValidationService>();
builder.Services.AddScoped<AuditSaveChangesInterceptor>();


builder.Services.AddSingleton(setting);
builder.Services.AddApplicationValidators();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme.",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });

    x.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
        }
    });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFEApp", policy =>
    {
        policy.WithOrigins(allowedOrigins!)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = setting.Issuer,
            ValidAudience = setting.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(setting.SecretKey)),
            ClockSkew = TimeSpan.Zero
        };
        opt.MapInboundClaims = true;
    });

var app = builder.Build();
app.UseCors("AllowFEApp");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
