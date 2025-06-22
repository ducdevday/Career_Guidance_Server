using CareerGuidance.BussinessLogic.Business;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.Validation;
using CareerGuidance.Data;
using CareerGuidance.Data.Interceptors;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Mapper;
using CareerGuidance.Setting;
using CareerGuidance.Validation.Service;

var builder = WebApplication.CreateBuilder(args);
var setting = EnviromentSetting.Instance;

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
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
