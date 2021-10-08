using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListaAeropuertoModel : PageModel
    {

        private readonly RepositorioAeropuertos repositorioAeropuertos;
        public IEnumerable<Aeropuertos> Aeropuertos {get;set;}

        public ListaAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
        {
            this.repositorioAeropuertos=repositorioAeropuertos;
        }        
        
        public void OnGet()
        {
            Aeropuertos=repositorioAeropuertos.GetAll();
        }
    }
}
