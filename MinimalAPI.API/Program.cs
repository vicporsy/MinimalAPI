using Microsoft.EntityFrameworkCore;
using MinimalAPI.AutoMapper;
using MinimalAPI.Endpoint;
using MinimalAPI.Infra.Contexts;
using MinimalAPI.RepositoryInitializer;
using MinimalAPI.ServiceInitializer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMemoryCache();

builder.Services.AddRepositoryConfiguration();
builder.Services.AddServiceConfiguration();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile(new MapperProfile());
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapApiEndpoints();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
