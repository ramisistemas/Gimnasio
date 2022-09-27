using GymEnCasa.App.Persistencia;
using GymEnCasa.App.Persistencia.AppRepositorios;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GymEnCasa.App.Presentacion.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityDataContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityDataContextConnection' not found.");

builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDataContext>();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IRepositorioCliente, RepositorioCliente>();
builder.Services.AddSingleton<IRepositorioValoracionNutricional,RepositorioValoracionNutricional>();
builder.Services.AddSingleton<IRepositorioTipoCuerpo, RepositorioTipoCuerpo>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
