using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Comentario
{
    public partial class BorrarComentario : System.Web.UI.Page
    {
        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            comentarioNegocio.BorrarComentario(Convert.ToInt32(Request.QueryString["id"]));
            Response.Redirect($"~/Post/verPost.aspx?id={Convert.ToInt32(Request.QueryString["idPost"])}");

        }
    }
}