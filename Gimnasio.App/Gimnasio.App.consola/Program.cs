using System;
using Gimnasio.App.Dominio;
using Gimnasio.App.Persistencia;

namespace Gimnasio.App.consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente=new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarCliente();
        }
        private static void AdicionarCliente()
        {
            var cliente = new Cliente
            {
                PrimerNombre = "Ramiro",
                PrimerApellido = "Cruzado",
                SegundoApellido ="Florez",
                Email ="ramiro.cruzado@ingenieros.com",
                Edad = "47",
                Telefono = "3017219646",
                Direccion ="Calle Primavera",
                Contraseña ="1234"               
            };
            _repoCliente.CrearCliente(cliente);
        }
    }
}
