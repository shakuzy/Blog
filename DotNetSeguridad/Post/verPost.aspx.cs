using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSeguridad.Post
{
    public partial class verPost : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();

        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            string parametroId = Request.QueryString["id"];
            int id = Convert.ToInt32(parametroId);

            
            Entidades.EntidadesPost elPost = postNegocio.ObtenerPost(id);
            if (elPost != null)
            {
                lblTitulo.Text = elPost.Titulo;
                lblResumen.Text = elPost.Resumen;
                lblCuerpo.Text = elPost.Cuerpo;
                List<CapaEntityFramework.Comentario> listado = comentarioNegocio.TodosLosComentarios(id);

                


                if (User.Identity.Name == ""){
                    txtAutor.Visible = true;
                } else if (User.Identity.Name != null)
                {
                    txtAutor.Visible = false;
                    lblAutor.Text = "Autor: " + User.Identity.Name;
                }

                if (User.IsInRole("admin")) {
                    
                    pnlAdmin.Visible = true;
                    
                    lstComentarios.DataSource = listado;
                    lstComentarios.DataBind();
                   
                }  else if (User.IsInRole("admin")!=true || User.Identity.Name == "") {
                    pnlUser.Visible = true;
                    
                    ListView1.DataSource = listado;
                    ListView1.DataBind();
                }

            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
           
        }

        protected void btn_AgregarComentario_Click(object sender, EventArgs e)
        {
            string autor = txtAutor.Text == "" ? User.Identity.Name : txtAutor.Text;
            int id = Convert.ToInt32(Request.QueryString["id"]);

            if (autor!="" && txtComentario.Text!="")
            {

                CapaEntityFramework.Comentario comentario = new CapaEntityFramework.Comentario()
                {
                    Autor = autor,
                    Comentario1 = txtComentario.Text,
                    IdPost = Convert.ToInt32(Request.QueryString["id"])
                };
                comentarioNegocio.AgregarComentario(comentario);
            }
            Response.Redirect($"~/Post/verPost.aspx?id={id}");

        }

        protected void btnBorrarTodoslosComentarios_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            comentarioNegocio.BorrarTodosLosComentarios(id);
            Response.Redirect($"~/Post/verPost.aspx?id={id}");
            

        }
    }
}