using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Post
{
    public partial class EditarPost : System.Web.UI.Page
    {
        PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Entidades.EntidadesPost post = postNegocio.ObtenerPost(id);
                if (post == null)
                {
                    Response.Redirect("~/Post/ABMPost/ABMPost.aspx");
                }
                else
                {
                    txtTitulo.Text = post.Titulo;
                    txtResumen.Text = post.Resumen;
                    txtCuerpo.Text = post.Cuerpo;


                }
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Entidades.EntidadesPost post = new Entidades.EntidadesPost()
            {
                Id = Convert.ToInt32(Request.QueryString["id"]),
                Titulo = txtTitulo.Text,
                Resumen = txtResumen.Text,
                Cuerpo = txtCuerpo.Text
            };

            postNegocio.ModificarPost(post);
            Response.Redirect("~/Post/ABMPost/ABMPost.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Post/ABMPost/ABMPost.aspx");
        }
    }
}