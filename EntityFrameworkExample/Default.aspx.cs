using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityFrameworkExample.Entidades;
using EntityFrameworkExample.Repositories;

namespace EntityFrameworkExample
{
    public partial class _Default : Page
    {
        private IUsuarioRepository usuarioRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioRepository = new UsuarioRepository(new MyDbContext());

            if (!IsPostBack)
            {                
                CarregaGrid();
            }
        }

        private void CarregaGrid()
        {
            var usuarios = usuarioRepository.ObterTodos();
            CarregaGrid(usuarios);
        }

        private void CarregaGrid(IEnumerable<Usuario> usuarios)
        {
            usuariosGrid.DataSource = usuarios;
            usuariosGrid.DataBind();
        }

        protected void usuariosGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = (int)e.Keys["Id"];

            usuarioRepository.Deletar(id);

            CarregaGrid();
        }

        protected void btnFiltrarNome_Click(object sender, EventArgs e)
        {
            var nomeFiltrado = txtFiltroNome.Text;
            var usuarios = usuarioRepository.ObterPorNome(nomeFiltrado);
            CarregaGrid(usuarios);
        }

        protected void btnFiltrarAtivo_Click(object sender, EventArgs e)
        {
            var usuarios = usuarioRepository.ObterAtivos();
            CarregaGrid(usuarios);  
        }
    }
}
