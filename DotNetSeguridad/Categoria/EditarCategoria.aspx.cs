using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Categoria
{
    public partial class EditarCategoria : System.Web.UI.Page
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Entidades.EntidadesCategoria categoria = categoriaNegocio.ObtenerCategoria(id);
                if (categoria == null)
                {
                    Response.Redirect("~/Categoria/VerCategorias.aspx");
                }
                else
                {
                    lblNombre.Text = categoria.Nombre;
                    txtNombre.Text = categoria.Nombre;

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.EntidadesCategoria categoria = new Entidades.EntidadesCategoria()
            {
                Id = Convert.ToInt32(Request.QueryString["id"]),
                Nombre = txtNombre.Text
            };

            categoriaNegocio.ActualizarCategoria(categoria);
            Response.Redirect("~/Categoria/VerCategorias.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Categoria/VerCategorias.aspx");

        }
    }
}