using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Post
{
    public partial class AgregarPost : System.Web.UI.Page
    {
        PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            Entidades.EntidadesPost post = new Entidades.EntidadesPost()
            {
                Titulo = txtTitulo.Text,
                Resumen = txtResumen.Text,
                Cuerpo = txtCuerpo.Text
            };

            postNegocio.InsertarPost(post);
            Response.Redirect("~/Post/ABMPost/ABMPost.aspx");

        }
    }
}