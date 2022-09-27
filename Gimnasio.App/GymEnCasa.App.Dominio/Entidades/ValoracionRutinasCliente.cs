using System;
using System.ComponentModel.DataAnnotations;

namespace GymEnCasa.App.Dominio
{
    public class ValoracionRutinasCliente
    {
        public int Id  {get;set;}
        
        public Cliente? Cliente {get;set;}        
        public DificultadEjercicio? DificultadEjercicio {get;set;}
        [Required]
        public float estatura {get;set;}
        [Required]
        public float peso {get;set;}
    }
}