using Microsoft.EntityFrameworkCore;
using Gimnasio.App.Dominio;

namespace Gimnasio.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<ConsejoNutricional> ConsejoNutricionales {get;set;}
        public DbSet<Dificultad> Dificultades {get;set;}
        public DbSet<Rutina> Rutinas {get;set;}
        public DbSet<Seguimiento> seguimientos {get;set;}
        public DbSet<ValoracionInicial> ValoracionIniciales {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
         if (!OptionsBuilder.IsConfigured) 
         {
            OptionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Gimnasio");
         }    
        }
    }

}