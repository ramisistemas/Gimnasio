using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Persistencia.AppRepositorios.Interfaz
{
    public interface IRepositorioValoracionNutricional
    {
        void CrearValoracionNutricional(ValoracionNutricionalCliente valoracionNutricional);
        ValoracionNutricionalCliente ConsultarValoracion(int idUsuario);
        decimal CalcularPesoIdeal(int idUsuario);
        decimal CalcularPorcentajeGrasaCorporal(int idUsuario);
        decimal CalcularIndiceMetabolicoBasal(int idUsuario);
    }
}
