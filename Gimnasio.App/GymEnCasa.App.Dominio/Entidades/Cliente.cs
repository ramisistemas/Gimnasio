using System;

namespace GymEnCasa.App.Dominio
{
    public class Cliente
    {
        public int Id {get;set;}
        public String PrimerNombre {get;set;}
        public String SegundoNombre {get;set;}
        public String PrimerApellido {get;set;}
        public String SegundoApellido {get;set;}
        public String Email {get;set;}
        public String Edad {get;set;}
        public String NumeroTelefonico {get;set;}
        public String Direccion {get;set;}
        public String Contrasena {get;set;}
        public Genero Genero{get;set;}
    }
}