using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;

namespace GymEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioDificultadEjercicio : IRepositorioDificultadEjercicio
    {
        private readonly AppContext _appContext = new AppContext();

        public DificultadEjercicio BuscarDificultadEjercicio(bool basico, bool intermedio, bool avanzado)
        {
            var idDificultad = 0;

            if (basico)
            {
                idDificultad = 1;
            }
            if (intermedio)
            {
                idDificultad = 2;
            }
            if (avanzado)
            {
                idDificultad = 3;
            }

            return _appContext.DificultadEjercicios.FirstOrDefault(dificultad => dificultad.Id == idDificultad);
        }
    }
}
