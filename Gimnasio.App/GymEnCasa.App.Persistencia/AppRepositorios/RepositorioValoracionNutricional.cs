using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;

namespace GymEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioValoracionNutricional : IRepositorioValoracionNutricional
    {
        private readonly AppContext _dbContext = new AppContext();
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioTipoCuerpo _tipoCuerpo;
        public RepositorioValoracionNutricional(IRepositorioCliente cliente, IRepositorioTipoCuerpo tipoCuerpo)
        {
            this._repositorioCliente = cliente;
            this._tipoCuerpo = tipoCuerpo;
        }

        public ValoracionNutricionalCliente ConsultarValoracion(int idUsuario)
        {
            var valoracion = (from valoracionNutricional in _dbContext.ValoracionNutricionalClientes
                              where valoracionNutricional.Cliente.Id == 1
                              select valoracionNutricional).FirstOrDefault();
            return valoracion;
        }

        public void CrearValoracionNutricional(ValoracionNutricionalCliente valoracionNutricional)
        {
            _dbContext.Attach(valoracionNutricional.Cliente);
            _dbContext.Attach(valoracionNutricional.TipoCuerpo);
            _dbContext.ValoracionNutricionalClientes.Add(valoracionNutricional);
            _dbContext.SaveChanges();
        }

        public decimal CalcularPesoIdeal(int idUsuario)
        {
            decimal pesoIdeal = 0;

            var cliente = _repositorioCliente.ConsultarCliente(idUsuario);
            var valoracion = ConsultarValoracion(idUsuario);

            switch (cliente.Genero.Id)
            {
                case 1:
                    pesoIdeal = (decimal)(56.2 + 1.41 * ((valoracion.estatura / 2.54) - 60));
                    break;
                case 2:
                    pesoIdeal = (decimal)(53.1 + 1.16 * ((valoracion.estatura / 2.54) - 60));
                    break;
            }

            return Math.Round((decimal)pesoIdeal, 2);
        }

        public decimal CalcularPorcentajeGrasaCorporal(int idUsuario)
        {
            decimal porcentajeGrasaCorporal = 0;

            var cliente = _repositorioCliente.ConsultarCliente(idUsuario);
            var valoracion = ConsultarValoracion(idUsuario);
            var edad = int.Parse(cliente.Edad);

            var estaturaCm = valoracion.estatura / 100;

            var imc = (double)(valoracion.peso / (estaturaCm * estaturaCm));

            switch (cliente.Genero.Id)
            {
                case 1:
                    porcentajeGrasaCorporal = (decimal)(1.20 * imc + 0.23 * edad - 16.2);
                    break;
                case 2:
                    porcentajeGrasaCorporal = (decimal)(1.20 * imc + 0.23 * edad - 5.4);
                    break;
            }

            return Math.Round((decimal)porcentajeGrasaCorporal, 2);
        }

        public decimal CalcularIndiceMetabolicoBasal(int idUsuario)
        {
            decimal indiceMetabolicoBasal = 0;

            var cliente = _repositorioCliente.ConsultarCliente(idUsuario);
            var valoracion = ConsultarValoracion(idUsuario);
            var edad = int.Parse(cliente.Edad);

            var estaturaCm = valoracion.estatura;

            switch (cliente.Genero.Id)
            {
                case 1:
                    indiceMetabolicoBasal = (decimal)((13.397 * valoracion.peso) + (4.799 * estaturaCm) - (5.677 * edad) + 88.362);
                    break;
                case 2:
                    indiceMetabolicoBasal = (decimal)((9.247 * valoracion.peso) + (3.098 * estaturaCm) - (4.330 * edad) + 447.593);
                    break;
            }

            return Math.Round((decimal)indiceMetabolicoBasal, 2);
        }
    }
}
