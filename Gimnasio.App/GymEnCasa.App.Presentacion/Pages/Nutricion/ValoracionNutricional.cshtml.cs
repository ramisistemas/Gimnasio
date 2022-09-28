using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyApp.Namespace
{
    public class ValoracionNutricionalModel : PageModel
    {
        private readonly IRepositorioValoracionNutricional _valoracionNutricional;
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioTipoCuerpo _tipoCuerpo;

        private int idUsuarioLogeado = 1;

        [BindProperty]
        public ValoracionNutricionalCliente Valoracion { get; set; }
        [BindProperty]
        public bool EctomorfoTipo { get; set; }
        [BindProperty]
        public bool MesomorfoTipo { get; set; }
        [BindProperty]
        public bool EndomorfoTipo { get; set; }

        public ValoracionNutricionalModel(IRepositorioValoracionNutricional valoracionNutricional,IRepositorioCliente repositorioCliente,IRepositorioTipoCuerpo tipoCuerpo)
        {
            this._valoracionNutricional = valoracionNutricional;
            this._repositorioCliente = repositorioCliente;
            this._tipoCuerpo = tipoCuerpo;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var cliente = _repositorioCliente.ConsultarCliente(idUsuarioLogeado);

            var idTipoCuerpo = _tipoCuerpo.HomologarTipoCuerpo(EctomorfoTipo, MesomorfoTipo, EndomorfoTipo);
            var tipoCuerpo = _tipoCuerpo.BuscarTipoCuerpo(idTipoCuerpo);

            Valoracion.Cliente = cliente;
            Valoracion.TipoCuerpo = tipoCuerpo;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _valoracionNutricional.CrearValoracionNutricional(Valoracion);

            return Redirect("/Nutricion/ConsejoNutricional");
        }
    }
}
