using System;

namespace Gimnasio.App.Dominio
{

    public class Rutina
    {
        public int Id {get;set;}
        public string TrenSuperior {get;set;}
        public string TrenInferior {get;set;}
        public string Abdominal {get;set;}
        public string GluteosPantorrila {get;set;}
        public Dificultad Dificultad {get;set;}
        public ValoracionInicial ValoracionInicial {get;set;}       
    }
}