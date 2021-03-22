using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class PostNegocio
    {
        private readonly PostDatos postDatos;

        public PostNegocio()
        {
            postDatos = new PostDatos();
        }

        public List<EntidadesPost> ObtenerTodosLosPost()
        {
            return postDatos.ObtenerTodosLosPost();
        }

        public EntidadesPost ObtenerPost(int Id)
        {
            return postDatos.ObtenerPost(Id);
        }

        public void InsertarPost(EntidadesPost post)
        {
            postDatos.InsertarPost(post);
        }

        public void BorrarPost(EntidadesPost post)
        {
            postDatos.BorrarPost(post);
        }

        public void ModificarPost(EntidadesPost post)
        {
            postDatos.ModificarPost(post);
        }
    }
}
