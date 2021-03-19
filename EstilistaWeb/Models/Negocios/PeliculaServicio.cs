using EstilistaWeb.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstilistaWeb.Models.Negocios
{
    public class PeliculaServicio
    {
        public Pelicula ObtenerPelicula()
        {
            var pelicula = new Pelicula();
            pelicula.Nombre = "Avenger";
            pelicula.Duracion = "205";
            pelicula.Pais = "USA";

            return pelicula;
        }
    }
}
