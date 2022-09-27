using System;
using System.ComponentModel.DataAnnotations;

namespace GymEnCasa.App.Dominio
{
    public class ValoracionRutinasCliente
    {
        public int Id  {get;set;}
        [Required]
        public Cliente? Cliente {get;set;}
        [Required]
        public DificultadEjercicio? DificultadEjercicio {get;set;}
        [Required]
        public float estatura {get;set;}
        [Required]
        public float peso {get;set;}
    }
}