using System;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;

namespace GymEnCasa.App.Console
{
    class program
    {
      private static IRepositorioCliente _repoCliente =new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        { 
          AdicionarCliente();
        }
        private static void AdicionarCliente()
        {
          var cliente = new Cliente
          {
            PrimerNombre="Ivanovich",
            SegundoNombre="dimitri",
            PrimerApellido="Mendeleiev",
            SegundoApellido="Ivanov",
            Email="ivanov79@gmail.com",
            Edad="27",
            NumeroTelefonico="323587796",
            Direccion="Av Siempre Viva #33-85",
            Contrasena="ivan1515",
          };
          _repoCliente.CrearCliente(cliente);
        }
    }
}




