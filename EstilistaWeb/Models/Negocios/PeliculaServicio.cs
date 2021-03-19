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

        public List<Pelicula> ObtenerListadoPelicula()
        {
            var pelicula = new Pelicula();
            pelicula.Nombre = "Avenger";
            pelicula.Duracion = "205";
            pelicula.Pais = "USA";

            var pelicula2 = new Pelicula();
            pelicula2.Nombre = "Batman";
            pelicula2.Duracion = "230";
            pelicula2.Pais = "USA";

            var listaPelicula = new List<Pelicula>();
            listaPelicula.Add(pelicula);
            listaPelicula.Add(pelicula2);

            return listaPelicula;
        }
    }
}
