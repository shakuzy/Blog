using System;
using System.Collections.Generic;
using Entidades;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AccesoDatos
{
    public class CategoriaDatos
    {
        private string CadenaConexion = "Server=.;Database=Blog;Trusted_Connection=True;";

        public List<EntidadesCategoria> ObtenerTodasLasCategorias()
        {

            List<EntidadesCategoria> resultado = new List<EntidadesCategoria>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {

                SqlCommand comando = new SqlCommand("SELECT * FROM Categorias", conexion);

                conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntidadesCategoria elPost = new EntidadesCategoria();
                        elPost.Id = Convert.ToInt32(reader[0]);
                        elPost.Nombre = reader["Nombre"].ToString();

                        resultado.Add(elPost);
                    }

                }
            }
            return resultado;
        }
        public EntidadesCategoria ObtenerCategoria(int Id)
        {
            EntidadesCategoria resultado = null;

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Categorias WHERE Id = {Id} ", connection);

                connection.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new EntidadesCategoria();
                        resultado.Id = Convert.ToInt32(reader[0]);
                        resultado.Nombre = reader["Nombre"].ToString();
                    }
                }
            }
            return resultado;
        }
        public void InsertarCategoria(EntidadesCategoria unaCategoria)
        {
            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                string strConsulta = $"INSERT INTO [Categorias]([Nombre]) VALUES ('{unaCategoria.Nombre}')";
                SqlCommand comando = new SqlCommand(strConsulta, connection);
                connection.Open();
                comando.ExecuteNonQuery();

            }
        }

        public void ActualizarCategoria(EntidadesCategoria unaCategoria)
        {
            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {

                SqlCommand comando = new SqlCommand($"UPDATE Categorias SET Nombre = '{unaCategoria.Nombre}' WHERE Id = {unaCategoria.Id}", connection);
                connection.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void BorrarCategoria(EntidadesCategoria unaCategoria)
        {
            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                string strConsulta = $"DELETE FROM Categorias WHERE Id = {unaCategoria.Id}";
                SqlCommand comando = new SqlCommand(strConsulta, connection);
                connection.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}