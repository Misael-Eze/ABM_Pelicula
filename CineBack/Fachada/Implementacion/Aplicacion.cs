using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IFuncionDao dao;
        public Aplicacion()
        {
            dao = new FuncionDao();
        }

        public bool SaveFuncion(Funcion oFuncion)
        {
            return dao.Crear(oFuncion);
        }
    }
}
