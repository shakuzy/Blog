using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Comentario
{
    public partial class EditarComentario : System.Web.UI.Page
    {
        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int intId = Convert.ToInt32(Request.QueryString["id"]);

                CapaEntityFramework.Comentario comentario = comentarioNegocio.ObtenerComentario(intId);
                txtAutor.Text = comentario.Autor;
                txtComentario.Text = comentario.Comentario1;
            }

        }

        protected void btnEditarComentario_Click(object sender, EventArgs e)
        {
            int intId = Convert.ToInt32(Request.QueryString["id"]);

            CapaEntityFramework.Comentario comentarionuevo = new CapaEntityFramework.Comentario()
            {
                Id = Convert.ToInt32(Request.QueryString["id"]),
                Autor = txtAutor.Text,
                Comentario1 = txtComentario.Text,
                IdPost = Convert.ToInt32(Request.QueryString["idPost"])
            };
            comentarioNegocio.EditarComentario(comentarionuevo);
            Response.Redirect($"~/Post/verPost.aspx?id={Convert.ToInt32(Request.QueryString["idPost"])}");

        }
    }
}