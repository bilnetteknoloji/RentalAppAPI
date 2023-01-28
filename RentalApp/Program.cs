using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RentalApp.Data;
using RentalApp.Data.Repository;
using RentalApp.Service;
using RentalApp.Service.Services;
using RentalApp.Service.Services.Products;
using Mapster;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddControllers().AddControllersAsServices().AddXmlDataContractSerializerFormatters();


string[] RentalDb =
{
"RentalApp",
"RentalApp.Core",
"RentalApp.Data",
"RentalApp.Service",
};

services.AddPersistenceServices(RentalDb);

//Data
services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rental.Api", Version = "v1" });
});
services.AddDbContext<RentalAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RentalDb")));


var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    var frontendURL = configuration.GetValue<string>("frontend_url");
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
    });
});


var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});

app.UseCors();
app.UseDeveloperExceptionPage();

app.UseCors();

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rental.Api v1"));
app.Run();
