using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Categoria
{
    public partial class BorrarCategoria : System.Web.UI.Page
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

            Entidades.EntidadesCategoria categoria = new Entidades.EntidadesCategoria()
            {
                Id = Convert.ToInt32(Request.QueryString["id"]),
            };

            categoriaNegocio.BorrarCategoria(categoria);
            Response.Redirect("~/Categoria/VerCategorias.aspx");
        }
    }
}