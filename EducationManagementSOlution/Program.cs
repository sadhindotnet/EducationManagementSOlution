using EducationManagement_DLL.Infrastructures.Base;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Json.Serialization;
using System.Text.Json;
using EducationManagement_DLL.Context;
using Microsoft.EntityFrameworkCore;
using EducationManagement_DLL.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using EducationManagementSOlution.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();
//builder.Services.AddControllers();

builder.Services.AddIdentity<ApplicationUser, Role>()
    .AddEntityFrameworkStores<SchoolContext>()
    .AddDefaultTokenProviders();
builder.Services.AddDbContext<SchoolContext>(op => {
    op.UseSqlServer(builder.Configuration
        .GetConnectionString("DefaultConnection")
     );
    op.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});


builder.Services.AddScoped<IUnitOfWork, UnitOFWork>();


builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddControllers(options =>
{
    options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
    options.OutputFormatters.Add(new SystemTextJsonOutputFormatter
            (new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                //ContractResolver=new CamelCasePropertyNamesContractResolver()
                PropertyNameCaseInsensitive = false,
                PropertyNamingPolicy = null,
                WriteIndented = true,
                TypeInfoResolver = JsonSerializerOptions.Default.TypeInfoResolver,
            }));
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
