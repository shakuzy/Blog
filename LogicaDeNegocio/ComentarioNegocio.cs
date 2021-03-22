using System;
using AccesoDatos;
using System.Collections.Generic;
using CapaEntityFramework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class ComentarioNegocio
    {
        private ComentarioDatos comentarioDatos = new ComentarioDatos();

        public List<Comentario> TodosLosComentarios(int postId)
        {
            return comentarioDatos.TodosLosComentarios(postId);
        }

        public void AgregarComentario(Comentario comentario)
        {
            comentarioDatos.AgregarComentario(comentario);
        }

        public void BorrarComentario(int idComentario)
        {
            comentarioDatos.BorrarComentario(idComentario);
        }

        public Comentario ObtenerComentario(int idComentario)
        {
            return comentarioDatos.ObtenerComentario(idComentario);
        }

        public void EditarComentario(Comentario ComentarioNuevo)
        {
            comentarioDatos.EditarComentario(ComentarioNuevo);
        }

        public void BorrarTodosLosComentarios(int idPost)
        {
            comentarioDatos.BorrarTodosLosComentarios(idPost);
        }
    }
}