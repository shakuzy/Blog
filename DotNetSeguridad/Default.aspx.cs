using LogicaDeNegocio;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad
{
    public partial class _Default : Page
    {
        private readonly PostNegocio postNegocio;

        

        public _Default()
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