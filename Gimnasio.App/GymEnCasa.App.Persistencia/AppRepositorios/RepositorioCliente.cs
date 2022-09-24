using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AppContext _appContext = new AppContext();
      
        public Cliente CrearCliente(Cliente cliente)
        {
            _appContext.Attach(cliente.Genero);
            var clienteEncontrado=_appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteEncontrado.Entity;
        }
        public Cliente ConsultarCliente(int idCliente)
        {
            return _appContext.Clientes.Include(cliente => cliente.Genero).FirstOrDefault(p => p.Id == idCliente);
        }
        public IEnumerable<Cliente> ConsultarClientes()
        {
            return _appContext.Clientes;
        }
        public Cliente ActualizarCliente(Cliente cliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(p=>p.Id==cliente.Id);
            if(clienteEncontrado!=null){
                clienteEncontrado.PrimerNombre=cliente.PrimerNombre;
                clienteEncontrado.SegundoNombre=cliente.SegundoNombre;
                clienteEncontrado.PrimerApellido=cliente.PrimerApellido;
                clienteEncontrado.SegundoApellido=cliente.SegundoApellido;
                clienteEncontrado.Email=cliente.Email;
                clienteEncontrado.Edad=cliente.Edad;
                clienteEncontrado.NumeroTelefonico=cliente.NumeroTelefonico;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Contrasena=cliente.Contrasena;
                
                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
        public void EliminarCliente(int idCliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(p=>p.Id==idCliente);
            if(clienteEncontrado==null)
            return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
        public List<Genero> BuscarGeneros()
        {
            return (from generos in _appContext.Generos
                    select generos).ToList();
        }

        public Genero BuscarGeneros(int IdGenero)
        {
            return _appContext.Generos.FirstOrDefault(p=>p.Id==IdGenero);
        }
    }
}