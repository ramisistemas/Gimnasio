using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente CrearCliente(Cliente cliente);
        Cliente ConsultatCliente(int idCliente);
        IEnumerable<Cliente> ConsultarClientes();
        Cliente ActualizarCliente(Cliente cliente);
        void EliminarCliente(int idCliente);
    }
}