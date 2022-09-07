using System;

namespace GymEnCasa.App.Dominio
{
    public class ConsejoNutricional
    {
        public int Id {get;set;}
        public TipoCuerpo TipoCuerpo {get;set;}
        public CategoriaNutricional CategoriaNutricional {get;set;}
        public String Descripcion {get;set;}
    }
}