using System;
using Gimnasio.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Gimnasio.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AppContext _appContext;
         public RepositorioCliente(AppContext appContext)
        {
           this._appContext= appContext;
        }
        public Cliente CrearCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        public Cliente ConsultarCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c=>c.Id==idCliente);
           
        }
        
        public IEnumerable <Cliente> ConsultarClientes()
        {
          return _appContext.Clientes;
        }
        public Cliente ActualizarCliente (Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c=>c.Id== cliente.Id);
            if(clienteEncontrado!=null)
            {
                clienteEncontrado.PrimerNombre=cliente.PrimerNombre;
                clienteEncontrado.SegundoNombre=cliente.SegundoNombre;
                clienteEncontrado.PrimerApellido=cliente.PrimerApellido;
                clienteEncontrado.SegundoApellido=cliente.SegundoApellido;
                clienteEncontrado.Email=cliente.Email;
                clienteEncontrado.Edad=cliente.Edad;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Contraseña=cliente.Contraseña; 

                _appContext.SaveChanges();             
            
            }
            return clienteEncontrado;
        }
        public void EliminarCliente (int idCliente)
        {
           var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c=>c.Id==idCliente);
           if(clienteEncontrado==null)
           return;
           _appContext.Clientes.Remove(clienteEncontrado);
           _appContext.SaveChanges();
        }
    }      
}
