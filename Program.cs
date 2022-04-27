using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using UniversityAPI.Data;
using UniversityAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

string connectionString = builder.Configuration.GetConnectionString("UniversityDatabase");
builder.Services.AddDbContext<StudentsContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");


app.UseAuthorization();
app.MapControllers();
app.Run();
