using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Persistencia.AppRepositorios.Interfaz
{
    public interface IRepositorioDificultadEjercicio
    {
        public DificultadEjercicio BuscarDificultadEjercicio(bool basico, bool intermedio, bool avanzado);
    }
}
