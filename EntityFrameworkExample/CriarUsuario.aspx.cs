using System;
using EntityFrameworkExample.Entidades;
using EntityFrameworkExample.Repositories;

namespace EntityFrameworkExample
{
    public partial class CriarUsuario : System.Web.UI.Page
    {
        private IUsuarioRepository repository;

        protected void Page_Load(object sender, EventArgs e)
        {
            repository = new UsuarioRepository(new MyDbContext());            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SalvaUsuario();

            Response.Redirect("Default.aspx");
        }

        private void SalvaUsuario()
        {
            var usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Sobrenome = txtSobrenome.Text
                };

            repository.Salvar(usuario);
        }
    }
}