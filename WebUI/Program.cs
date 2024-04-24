using HundeRally.Application;
using HundeRally.Application.Services;
using HundeRally.Domain.Interfaces;
using HundeRally.Infrastructure;
using HundeRally.Infrastructure.Data;
using HundeRally.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using HundeRally.WebUI.Server.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// ClassLibraries
builder.Services.AddApplication();
builder.Services.AddInfrastructure();




// Connection
//Repositories og service denpendencies
builder.Services.AddScoped<IObstacleService, ObstacleService>();
builder.Services.AddScoped<IObstacleRepository, ObstacleRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();

