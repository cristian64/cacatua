﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Libreria
{
    sealed class PeticionCAD
    {

        private static readonly PeticionCAD instancia = new PeticionCAD();
        static string cadenaConexion;

        public static PeticionCAD Instancia
        {
            get { return instancia; }
        }


        private PeticionCAD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cacatua"].ConnectionString;
        }

        public ArrayList ObtenerSinContestar()
        {
            ArrayList peticiones = new ArrayList();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM peticiones where respuesta is NULL";

                SqlDataReader reader = comando.ExecuteReader();
                // Recorremos el reader y vamos insertando en el array list
                while (reader.Read())
                {
                    peticiones.Add(obtenerDatos(reader));
                }
            }
            return peticiones;
        }

        private ENPeticion obtenerDatos(SqlDataReader reader)
        {
            ENPeticion peticion = new ENPeticion();
            peticion.Id = int.Parse(reader["id"].ToString());
            peticion.Asunto = reader["asunto"].ToString();
            peticion.Texto = reader["texto"].ToString();
            ENUsuario us = ENUsuario.Obtener(int.Parse(reader["usuario"].ToString()));
            peticion.Usuario = us;
            peticion.Respuesta = reader["respuesta"].ToString();
            peticion.Fecha = DateTime.Parse(reader["fecha"].ToString());

            return peticion;
        }

        public ArrayList ObtenerContestadas()
        {
            ArrayList peticiones = new ArrayList();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM peticiones where respuesta is not NULL";

                SqlDataReader reader = comando.ExecuteReader();
                // Recorremos el reader y vamos insertando en el array list
                while (reader.Read())
                {
                    peticiones.Add(obtenerDatos(reader));
                }
            }
            return peticiones;
        }

        public ArrayList ObtenerTodas()
        {
            ArrayList peticiones = new ArrayList();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM peticiones";

                SqlDataReader reader = comando.ExecuteReader();
                // Recorremos el reader y vamos insertando en el array list
                while (reader.Read())
                {
                    peticiones.Add(obtenerDatos(reader));
                }
            }
            return peticiones;
        }

        public ENPeticion GetPeticion(int id)
        {
            ENPeticion peticion = new ENPeticion();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM peticiones where id=" + id;
                //comando.Parameters.AddWithValue("@idpet", id);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    peticion = obtenerDatos(reader);
                }
            }
            return peticion;
        }

        public bool ActualizarPeticion(ENPeticion peticion)
        {
            int resultado = 0;
            bool actualizada = false;
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                // Abrimos la conexión
                conexion.Open();
                // Creamos el comando
                SqlCommand comando = new SqlCommand();
                // Le asignamos la conexión al comando
                comando.Connection = conexion;
                comando.CommandText = "UPDATE peticiones " +
                    "SET respuesta = @respuesta " +
                    "WHERE id = @id";
                comando.Parameters.AddWithValue("@respuesta", peticion.Respuesta);
                comando.Parameters.AddWithValue("@id", peticion.Id);
                resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                    actualizada = true;
            }
            return actualizada;
        }

        public bool BorrarPeticion(int id)
        {
            ENPeticion peticion = new ENPeticion();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM peticiones where id=" + id;

                SqlDataReader reader = comando.ExecuteReader();
            }
            return true;
        }

        public ArrayList Obtener(string asunto, string texto, int usuario, int mostrar, ref DateTime inicio, ref DateTime final, bool porFecha)
        {
            ArrayList peticiones = null;


            SqlConnection conexion = null;
            try
            {
                // Creamos y abrimos la conexión.
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                // Componemos la cadena de la sentencia.
                string sentencia = "select * from peticiones";
                string condiciones = ""; //= " where respuesta is NULL";

                DateTime ini = new DateTime(inicio.Year, inicio.Month, inicio.Day, 0, 0, 0);
                DateTime fin = new DateTime(final.Year, final.Month, final.Day, 23, 59, 59);




                if (mostrar == 1)
                {
                    condiciones += " where respuesta is NULL";
                }
                else
                {
                    if (mostrar == 2)
                    {
                        condiciones += " where respuesta is not NULL";
                    }
                }

                if (asunto != "")
                {
                    if (condiciones == "")
                    {
                        condiciones += " where asunto like '%" + @asunto + "%'";
                    }
                    else
                    {
                        condiciones += " and asunto like '%" + @asunto + "%'";
                    }
                }
                if (texto != "")
                {
                    if (condiciones == "")
                    {
                        condiciones += " where texto like '%" + @texto + "%'";
                    }
                    else
                    {
                        condiciones += " and texto like '%" + @texto + "%'";
                    }
                }
                if (usuario != 0)
                {
                    if (condiciones == "")
                    {
                        condiciones += " where usuario=" + @usuario;
                    }
                    else
                    {
                        condiciones += " and usuario=" + @usuario;
                    }
                }

                if (porFecha)
                {

                    if (condiciones == "")
                    {
                        condiciones += " where fecha between @fechainicio and @fechafin ";
                    }
                    else
                    {
                        condiciones += " and fecha between @fechainicio and @fechafin ";
                    }

                }

                sentencia = sentencia + condiciones;

                // Asignamos la cadena de sentencia y establecemos los parámetros.
                SqlCommand comando = new SqlCommand(sentencia, conexion);

                if (asunto != "")
                    comando.Parameters.AddWithValue("@asunto", asunto);

                if (asunto != "")
                    comando.Parameters.AddWithValue("@texto", texto);

                if (asunto != "")
                    comando.Parameters.AddWithValue("@usuario", usuario);

                if (porFecha)
                {
                    comando.Parameters.AddWithValue("@fechainicio", ini);
                    comando.Parameters.AddWithValue("@fechafin", fin);
                }

               

                // Realizamos la consulta.
                SqlDataReader dataReader = comando.ExecuteReader();

                // Insertamos todas las filas extraidas en el vector.
                peticiones = new ArrayList();
                while (dataReader.Read())
                {
                    ENPeticion peticion = obtenerDatos(dataReader);
                    peticiones.Add(peticion);
                }

                // Cerramos la consulta.
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ArrayList Peticion.Obtener() " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

            return peticiones;
        }

        public int ObtenerNumeroPeticiones()
        {

            int n = 0;
            SqlConnection conexion = null;
            try
            {
                // Creamos la conexion
                conexion = new SqlConnection(cadenaConexion);
                // Abrimos la conexión
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT count(*) numero FROM peticiones";
                

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    n = int.Parse(reader["numero"].ToString());
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Numero de peticiones: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
            return n;
            
        }

        public int ObtenerNumeroPeticionesSinContestar()
        {

            int n = 0;
            SqlConnection conexion = null;
            try
            {
                // Creamos la conexion
                conexion = new SqlConnection(cadenaConexion);
                // Abrimos la conexión
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT count(*) numero FROM peticiones where respuesta is NULL";


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    n = int.Parse(reader["numero"].ToString());
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Numero de peticiones: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
            return n;

        }

        public string ObtenerUltimaPeticion()
        {

            string texto = "";
            SqlConnection conexion = null;
            try
            {
                // Creamos la conexion
                conexion = new SqlConnection(cadenaConexion);
                // Abrimos la conexión
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT texto FROM peticiones order by fecha";


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    texto = reader["texto"].ToString();
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Numero de peticiones: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
            return texto;

        }

    }
}
