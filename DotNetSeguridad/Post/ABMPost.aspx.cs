using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Post
{
    public partial class ABMPost : System.Web.UI.Page
    {
        private readonly PostNegocio postNegocio;

        public ABMPost()
        {
            postNegocio = new PostNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Entidades.EntidadesPost> listado = postNegocio.ObtenerTodosLosPost();
                lstPosteos.DataSource = listado;
                lstPosteos.DataBind();
            }
        }
    }
}