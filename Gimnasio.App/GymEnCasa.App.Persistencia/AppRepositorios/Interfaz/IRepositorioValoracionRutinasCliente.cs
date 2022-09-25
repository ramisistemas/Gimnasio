using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia

{
    public interface IRepositorioValoracionRutinasCliente
    {
        ValoracionRutinasCliente CrearRutina(ValoracionRutinasCliente rutina);
        ValoracionRutinasCliente ConsultarRutina(int idRutina);
        IEnumerable <ValoracionRutinasCliente> ConsultarRutinas();
        ValoracionRutinasCliente ActualizarRutina (ValoracionRutinasCliente rutina);
        void EliminarRutina (int idRutina);
    }
}