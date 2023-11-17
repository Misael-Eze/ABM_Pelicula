using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Pelicula
    {
        public int Pelicula_ID { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public string Idioma { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }
        public Pelicula()
        {
            Pelicula_ID = 0;
            Titulo = string.Empty;
            Genero = string.Empty;
            Director = string.Empty;
            Idioma = string.Empty;
            Duracion = 0;
            Clasificacion = string.Empty;
        }
        public Pelicula(int nro, string tit, string gen, string dir, string idi, int dur, string clas)
        {
            Pelicula_ID = nro;
            Titulo = tit;
            Genero = gen;
            Director = dir;
            Idioma = idi;
            Duracion = dur;
            Clasificacion = clas;
        }
    }
}
