using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Categoria
{
    public partial class VerCategorias : System.Web.UI.Page
    {
        private readonly CategoriaNegocio categoriaNegocio;

        public VerCategorias()
        {
            categoriaNegocio = new CategoriaNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Entidades.EntidadesCategoria> listado = categoriaNegocio.ObtenerTodasLasCategorias();
                lstPosteos.DataSource = listado;
                lstPosteos.DataBind();
            }
        }
    }
}