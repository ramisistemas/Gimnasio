using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioValoracionRutinasCliente:IRepositorioValoracionRutinasCliente
    {
        private readonly AppContext _appContext=new AppContext();
         
        public ValoracionRutinasCliente CrearRutina(ValoracionRutinasCliente rutina)
        {
            _appContext.Attach(rutina.Cliente);
            _appContext.Attach(rutina.DificultadEjercicio);
            var rutinaAdicionada = _appContext.ValoracionRutinasClientes.Add(rutina);
            _appContext.SaveChanges();
            return rutinaAdicionada.Entity;
        }

        public ValoracionRutinasCliente ConsultarRutina(int idRutina)
        {
            return _appContext.ValoracionRutinasClientes.FirstOrDefault(r=>r.Id==idRutina);
           
        }
        
        public IEnumerable <ValoracionRutinasCliente> ConsultarRutinas()
        {
          return _appContext.ValoracionRutinasClientes;
        }
        public ValoracionRutinasCliente ActualizarRutina (ValoracionRutinasCliente rutina)
        {
            var rutinaEncontrada = _appContext.ValoracionRutinasClientes.FirstOrDefault(c=>c.Id== rutina.Id);
            if(rutinaEncontrada!=null)
            {
                rutinaEncontrada.DificultadEjercicio=rutina.DificultadEjercicio;
                                               

                _appContext.SaveChanges();             
            
            }
            return rutinaEncontrada;
        }
        public void EliminarRutina (int idRutina)
        {
           var rutinaEncontrada = _appContext.ValoracionRutinasClientes.FirstOrDefault(c=>c.Id==idRutina);
           if(rutinaEncontrada==null)
           return;
           _appContext.ValoracionRutinasClientes.Remove(rutinaEncontrada);
           _appContext.SaveChanges();
        }
    }      
}