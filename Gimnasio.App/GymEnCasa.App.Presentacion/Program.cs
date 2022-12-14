using GymEnCasa.App.Persistencia;
using GymEnCasa.App.Persistencia.AppRepositorios;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IRepositorioCliente, RepositorioCliente>();
builder.Services.AddSingleton<IRepositorioValoracionNutricional,RepositorioValoracionNutricional>();
builder.Services.AddSingleton<IRepositorioTipoCuerpo, RepositorioTipoCuerpo>();
builder.Services.AddSingleton<IRepositorioValoracionRutinasCliente, RepositorioValoracionRutinasCliente>();
builder.Services.AddSingleton<IRepositorioDificultadEjercicio, RepositorioDificultadEjercicio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
