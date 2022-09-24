using System.ComponentModel.DataAnnotations;


namespace GymEnCasa.App.Dominio
{
    public class Cliente
    {
        public int Id {get;set;}
        
        public string PrimerNombre {get;set;}

        public string SegundoNombre {get;set;}

        public string PrimerApellido {get;set;}

        public string SegundoApellido {get;set;}
        [Required]
        public string Email {get;set;}

        public string Edad {get;set;}

        public string NumeroTelefonico {get;set;}

        public string Direccion {get;set;}

        public string Contrasena {get;set;}

        public Genero? Genero{get;set;}
    }
}