using System;

namespace GymEnCasa.App.Dominio
{
    public class ValoracionNutricionalCliente
    {
        public int Id  {get;set;}
        public Cliente Cliente {get;set;}
        public TipoCuerpo TipoCuerpo {get;set;}
        public float estatura {get;set;}
        public float peso {get;set;}
    }
}