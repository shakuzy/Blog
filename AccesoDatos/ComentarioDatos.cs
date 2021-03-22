﻿using CapaEntityFramework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ComentarioDatos
    {
        private BlogEntities entidades = new BlogEntities(); //representa la "conexion" con la base de datos

        public List<Comentario> TodosLosComentarios(int postId)
        {
            List<Comentario> resultado;


            var consulta = from c in entidades.Comentarios
                           where c.IdPost == postId
                           select c;

            resultado = consulta.ToList(); //Aca efectivamente hace la consulta con la base de datos
            return resultado;
        }

        public void AgregarComentario(Comentario comentario)
        {
            entidades.Comentarios.Add(comentario);
            entidades.SaveChanges();
        }

        public void BorrarComentario(int idComentario)
        {
            Comentario comentario = entidades.Comentarios.Where(x => x.Id == idComentario).FirstOrDefault();
            entidades.Comentarios.Remove(comentario);
            entidades.SaveChanges();
        }

        public Comentario ObtenerComentario(int IdComentario)
        {
            Comentario resultado;


            var consulta = from c in entidades.Comentarios
                           where c.Id == IdComentario
                           select c;

            resultado = consulta.FirstOrDefault(); //Aca efectivamente hace la consulta con la base de datos
            return resultado;
        }

        public void EditarComentario(Comentario comentarioNuevo)
        {
            Comentario comentario = entidades.Comentarios.Where(x => x.Id == comentarioNuevo.Id).FirstOrDefault();
            comentario.Autor = comentarioNuevo.Autor;
            comentario.Comentario1 = comentarioNuevo.Comentario1;
            entidades.SaveChanges();
        }

        public void BorrarTodosLosComentarios(int idPost)
        {
            List<Comentario> comentarios = entidades.Comentarios.Where(x => x.IdPost == idPost).ToList();
            entidades.Comentarios.RemoveRange(comentarios);
            entidades.SaveChanges();
        }
    }
}