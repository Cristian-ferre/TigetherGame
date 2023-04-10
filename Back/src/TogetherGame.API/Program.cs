using Microsoft.EntityFrameworkCore;
using TogetherGame.API.Extensions;
using TogetherGame.API.IoC;
using TogetherGame.Identity.Data;
using TogetherGame.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(builder.Configuration);
builder.Services.RegisterServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IdentityDataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("conexaoPadrao")));

builder.Services.AddDbContext<TogetherGameContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("conexaoPadrao")));


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




// Add services to the container.

// public void ConfigureServices(IServiceCollection services)
// {
//     services.AddAuthentication(Configuration);
//     services.RegisterServices(Configuration);

// }