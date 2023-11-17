using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Funcion
    {
        public int Id_Funcion { get; set; }
        public Pelicula Pelicula { get; set; }
        public int Sala { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public Funcion()
        {
            Pelicula = new Pelicula();
            Sala = 0;
            Dia = DateTime.Now;
            Hora = DateTime.Now;
        }
        public Funcion(Pelicula oPelicula, int sala, DateTime dia, DateTime hora)
        {
            Pelicula = oPelicula;
            Sala = sala;
            Dia = dia;
            Hora = hora;
        }
    }
}
