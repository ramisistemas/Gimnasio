using System;

namespace Gimnasio.App.Dominio
{
    public class Cliente
    {
      public int Id {get;set;}
      public string PrimerNombre{get;set;}
      public string SegundoNombre {get;set;}
      public string PrimerApellido {get;set;}
      public string SegundoApellido {get;set;}
      public string Email {get;set;}
      public string Edad {get;set;}
      public string Telefono {get;set;}
      public string Direccion {get;set;}
      public string Contraseña {get;set;} 
      public Rutina Rutina {get;set;}
      public Seguimiento Seguimiento {get;set;}
      public ConsejoNutricional ConsejoNutricional {get;set;}
          
    }

}