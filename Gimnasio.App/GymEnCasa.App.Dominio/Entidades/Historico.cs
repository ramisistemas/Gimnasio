using System;

namespace GymEnCasa.App.Dominio
{
    public class Historico
    {
        public int Id  {get;set;}
        public Cliente Cliente{get;set;}
        public RutinasEjercicio RutinasEjercicio {get;set;}
        public DateTime Fecha  {get;set;}
    }
}