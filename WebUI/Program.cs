using HundeRally.Application;
using HundeRally.Application.Services;
using HundeRally.Domain;
using HundeRally.Infrastructure;
using HundeRally.Infrastructure.Repositories;
using WebUI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// ClassLibraries
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

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

