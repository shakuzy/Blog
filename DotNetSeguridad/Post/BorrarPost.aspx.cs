using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Post
{
    public partial class BorrarPost : System.Web.UI.Page
    {
        PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidades.EntidadesPost post = new Entidades.EntidadesPost()
            {
                Id = Convert.ToInt32(Request.QueryString["id"])

            };
            if (post != null)
            {
                postNegocio.BorrarPost(post);

            }
            Response.Redirect("~/Post/ABMPost.aspx");



        }
    }
}