using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;
using GymEnCasa.App.Persistencia.AppRepositorios.Interfaz;
using GymEnCasa.App.Presentacion.Pages.Rutinas;

namespace GymEnCasa.App.Presentacion.Pages

{
    public class ValoracionRutinasModel : PageModel
    {
        [BindProperty]
        public ValoracionRutinasCliente valoracionRutinasCliente { get; set; }
        [BindProperty]
        public bool DificultadBasico { get; set; }
        [BindProperty]
        public bool DificultadIntermedio { get; set; }
        [BindProperty]
        public bool DificultadAvanzado { get; set; }

        private readonly IRepositorioValoracionRutinasCliente _repoValoracioRutinasCliente;
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioDificultadEjercicio _repositorioDificultadEjercicio;
        
        public ValoracionRutinasModel(IRepositorioValoracionRutinasCliente repoValoracioRutinasCliente,IRepositorioCliente repoCliente,IRepositorioDificultadEjercicio repositorioDificultadEjercicio)
        {
            _repoValoracioRutinasCliente = repoValoracioRutinasCliente;
            _repositorioCliente = repoCliente;
            _repositorioDificultadEjercicio = repositorioDificultadEjercicio;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var cliente = _repositorioCliente.ConsultarCliente(1);
            var dificultad = _repositorioDificultadEjercicio.BuscarDificultadEjercicio(DificultadBasico, DificultadIntermedio, DificultadAvanzado);

            valoracionRutinasCliente.Cliente = cliente;
            valoracionRutinasCliente.DificultadEjercicio = dificultad;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            

            _repoValoracioRutinasCliente.CrearRutina(valoracionRutinasCliente);
            return RedirectToPage("/Rutinas/NivelBasico");
        }


    }
}
