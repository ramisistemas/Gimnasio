using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymEnCasa.App.Presentacion.Pages
{
    public class RegistrarModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente {get; set;}
        [BindProperty]
        public int IdGenero { get; set;}
        
        public List<Genero> Generos{get; set;}
        private readonly IRepositorioCliente _repoCliente;
        public RegistrarModel(IRepositorioCliente repoCliente)
        {
            _repoCliente = repoCliente;
        }

        public void OnGet()
        {
          Generos = this._repoCliente.BuscarGeneros();
        }
        
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); //hasta que el usuario no complete los datos, la info no se enviara
            }
            var genero = this._repoCliente.BuscarGeneros(IdGenero);
            Cliente.Genero = genero;
            _repoCliente.CrearCliente(Cliente);
           
            return RedirectToPage("/Index"); //Si todos los campos fueron llenado redigir la pag al Index


        }
    }
}
