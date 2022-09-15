using Microsoft.EntityFrameworkCore;
using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Genero> Generos{get;set;}
        public DbSet<ConsejoNutricional> ConsejoNutricionales {get;set;}
        public DbSet<DificultadEjercicio> DificultadEjercicios {get;set;}
        public DbSet<RutinasEjercicio> RutinasEjercicios {get;set;}
        public DbSet<Historico> Historicos {get;set;}
        public DbSet<TipoCuerpo> TipoCuerpos {get;set;}
        public DbSet<CategoriaNutricional> CategoriaNutricionales {get;set;}
        public DbSet<ValoracionNutricionalCliente> ValoracionNutricionalClientes {get;set;}
        public DbSet<ValoracionRutinasCliente> ValoracionRutinasClientes {get;set;} 
        public DbSet<ZonaTrabajo> ZonaTrabajos {get;set;} 
        //Conexion a la base de datos local
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if(!optionsBuilder.IsConfigured)
            
                optionsBuilder.UseSqlServer("Data Source=YHOR\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
                //Data Source=YHOR\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True
        }
    }
}