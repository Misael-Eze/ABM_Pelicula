using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Implementacion
{
    internal class FuncionDao : IFuncionDao
    {
        public bool Actualizar(Funcion oFuncion)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Funcion oFuncion)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_PELICULA";
                comando.Parameters.AddWithValue("@titulo", oFuncion.Pelicula.Titulo);
                comando.Parameters.AddWithValue("@genero", oFuncion.Pelicula.Genero);
                comando.Parameters.AddWithValue("@director", oFuncion.Pelicula.Director);
                comando.Parameters.AddWithValue("@idioma", oFuncion.Pelicula.Idioma);
                comando.Parameters.AddWithValue("@duracion", oFuncion.Pelicula.Duracion);
                comando.Parameters.AddWithValue("@clasificacion", oFuncion.Pelicula.Clasificacion);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_pelicula";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int peliculaNro = (int)parametro.Value;

                SqlCommand cmdDetalle;
                cmdDetalle = new SqlCommand("SP_INSERTAR_FUNCION", conexion, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_pelicula", peliculaNro);
                cmdDetalle.Parameters.AddWithValue("@dia", oFuncion.Dia);
                cmdDetalle.Parameters.AddWithValue("@hora", oFuncion.Hora);
                cmdDetalle.Parameters.AddWithValue("@id_sala", oFuncion.Sala);

                cmdDetalle.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                if(t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }
    }
}
