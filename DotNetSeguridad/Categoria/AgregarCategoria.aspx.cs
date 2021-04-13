using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Categoria
{
    public partial class AgregarCategoria : System.Web.UI.Page
    {

        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public string nombrenuevo;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Entidades.EntidadesCategoria categoria = new Entidades.EntidadesCategoria()
            {
                Nombre = txtNombre.Text
            };


            categoriaNegocio.InsertarCategoria(categoria);
            Response.Redirect("~/Categoria/VerCategorias/VerCategorias.aspx");
        }
    }
}