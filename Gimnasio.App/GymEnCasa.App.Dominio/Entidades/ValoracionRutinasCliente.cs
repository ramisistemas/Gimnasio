using System;

namespace GymEnCasa.App.Dominio
{
    public class ValoracionRutinasCliente
    {
        public int Id  {get;set;}
        public Cliente? Cliente {get;set;}
        public DificultadEjercicio? DificultadEjercicio {get;set;}
        public float estatura {get;set;}
        public float peso {get;set;}
    }
}