using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;

namespace GymEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoCuerpo : IRepositorioTipoCuerpo
    {
        private readonly AppContext _appContext = new AppContext();
        private const int EctomorfoId = 1;
        private const int Mesomorfo = 2;
        private const int Endomorfo = 3;
        public TipoCuerpo BuscarTipoCuerpo(int idTipoCuerpo)
        {
            var tipoCuerpo = _appContext.TipoCuerpos.FirstOrDefault(tipo => tipo.Id == idTipoCuerpo);
            return tipoCuerpo;
        }

        public int HomologarTipoCuerpo(bool ectomorfo, bool mesomorfo, bool endomorfo)
        {
            var idTipoCuerpo = 0;

            if (ectomorfo is true)
            {
                idTipoCuerpo = EctomorfoId;
            }

            if (mesomorfo is true)
            {
                idTipoCuerpo = Mesomorfo;
            }
            
            if (endomorfo is true)
            {
                idTipoCuerpo = Endomorfo;
            }

            return idTipoCuerpo;
        }
    }
}
