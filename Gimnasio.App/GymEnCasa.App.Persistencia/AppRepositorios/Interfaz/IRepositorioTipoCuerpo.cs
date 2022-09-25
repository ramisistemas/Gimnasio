using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Persistencia.AppRepositorios.Interfaz
{
    public interface IRepositorioTipoCuerpo
    {
        TipoCuerpo BuscarTipoCuerpo(int idTipoCuerpo);
        int HomologarTipoCuerpo(bool ectomorfo, bool mesomorfo, bool endomorfo);
    }
}
