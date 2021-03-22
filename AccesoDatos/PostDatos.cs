using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PostDatos
    {
        private string CadenaConexion = "Server=.;Database=Blog;Trusted_Connection=True;";
        public List<EntidadesPost> ObtenerTodosLosPost()
        {

            List<EntidadesPost> resultado = new List<EntidadesPost>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {

                SqlCommand comando = new SqlCommand("SELECT * FROM Post", conexion);

                conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntidadesPost elPost = new EntidadesPost();
                        elPost.Id = Convert.ToInt32(reader[0]);
                        elPost.Titulo = reader["Titulo"].ToString();
                        elPost.Resumen = reader.GetString(2);
                        elPost.Cuerpo = reader.GetString(3);
                        resultado.Add(elPost);
                    }

                }
            }
            return resultado;
        }

        public EntidadesPost ObtenerPost(int Id)
        {
            EntidadesPost resultado = null;

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Post WHERE Id = {Id} ", connection);

                connection.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new EntidadesPost();
                        resultado.Id = Convert.ToInt32(reader[0]);
                        resultado.Titulo = reader["Titulo"].ToString();
                        resultado.Resumen = reader.GetString(2);
                        resultado.Cuerpo = reader.GetString(3);
                    }
                }
            }
            return resultado;
        }

        public void InsertarPost(EntidadesPost unPost)
        {
            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                string strConsulta = $"INSERT INTO [Post]([Titulo],[Resumen],[Cuerpo]) VALUES ('{unPost.Titulo}','{unPost.Resumen}','{unPost.Cuerpo}')";
                SqlCommand comando = new SqlCommand(strConsulta, connection);
                connection.Open();
                comando.ExecuteNonQuery();

            }
        }

        public void BorrarPost(EntidadesPost post)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand($"DELETE FROM Post WHERE Id={post.Id}", conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void ModificarPost(EntidadesPost post)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand($"UPDATE Post SET Titulo='{post.Titulo}', Resumen='{post.Resumen}', Cuerpo='{post.Cuerpo}' WHERE Id={post.Id}", conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}



