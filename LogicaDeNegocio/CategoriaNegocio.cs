using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class CategoriaNegocio
    {
        private readonly CategoriaDatos categoriaDatos;

        public CategoriaNegocio()
        {
            categoriaDatos = new CategoriaDatos();
        }

        public List<EntidadesCategoria> ObtenerTodasLasCategorias()
        {
            return categoriaDatos.ObtenerTodasLasCategorias();
        }

        public EntidadesCategoria ObtenerCategoria(int Id)
        {
            return categoriaDatos.ObtenerCategoria(Id);
        }

        public bool InsertarCategoria(EntidadesCategoria categoria)
        {
            bool esValido = true;
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                esValido = false;
            }
            if (esValido == true)
            {
                categoriaDatos.InsertarCategoria(categoria);
            }
            return esValido;
        }

        public bool ActualizarCategoria(EntidadesCategoria categoria)
        {
            bool esValido = true;
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                esValido = false;
            }
            if (esValido == true)
            {
                categoriaDatos.ActualizarCategoria(categoria);
            }
            return esValido;
        }

        public void BorrarCategoria(EntidadesCategoria categoria)
        {

            categoriaDatos.BorrarCategoria(categoria);

        }
    }
}
