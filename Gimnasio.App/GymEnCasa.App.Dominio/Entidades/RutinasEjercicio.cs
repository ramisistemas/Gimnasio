using System;

namespace GymEnCasa.App.Dominio
{
    public class RutinasEjercicio
    {
        public int Id  {get;set;}
        public ZonaTrabajo ZonaTrabajo {get;set;}
        public DificultadEjercicio DificultadEjercicio {get;set;}
        public String NombreEjercicio {get;set;}
        public String DescripcionEjercicio {get;set;}
        public String AyudaMultimedia {get;set;}
    }
}