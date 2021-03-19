using EstilistaWeb.Models.Negocios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstilistaWeb.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: PeliculasController
        public ActionResult Index()
        {
            var peliculaServicio = new PeliculaServicio();
            var pelicula = peliculaServicio.ObtenerPelicula();
            return View(pelicula);
        }

        public ActionResult ListaPeliculas()
        {
            var peliculaServicio = new PeliculaServicio();
            var listaPeliculas = peliculaServicio.ObtenerListadoPelicula();
            return View(listaPeliculas);
        }

        [HttpPost]
        public ActionResult Formulario(string nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }
        [HttpGet]
        public ActionResult Formulario()
        {
            return View();
        }
    }
}
