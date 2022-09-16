using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;

namespace GymEnCasa.App.Presentacion.Pages
{
    public class RegistrarModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente {get; set;}

        private readonly IRepositorioCliente _repoCliente;

        public RegistrarModel(IRepositorioCliente repoCliente)
        {
            _repoCliente = repoCliente;
        }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); //hasta que el usuario no complete los datos, la info no se enviara
            }
            _repoCliente.CrearCliente(Cliente);
            return RedirectToPage("/Index"); //Si todos los campos fueron llenado redigir la pag al Index
        }
    }
}
