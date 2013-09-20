using System;
using EntityFrameworkExample.Entidades;
using EntityFrameworkExample.Repositories;

namespace EntityFrameworkExample
{
    public partial class Alterar : System.Web.UI.Page
    {
        private IUsuarioRepository usuarioRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioRepository = new UsuarioRepository(new MyDbContext());

            if (!IsPostBack)
            {
                var id = ObtemIdDoUsuarioNaUrl();

                var usuario = usuarioRepository.ObterPorId(id);

                PreencheCampos(usuario);
            }
        }        

        private void PreencheCampos(Usuario usuario)
        {
            hiddenId.Value = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtSobrenome.Text = usuario.Sobrenome;
            chkAtivo.Checked = usuario.Ativo;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AtualizaUsuario();

            Response.Redirect("Default.aspx");            
        }

        private void AtualizaUsuario()
        {
            var usuarioId = int.Parse(hiddenId.Value);

            var usuario = new Usuario
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Ativo = chkAtivo.Checked
            };

            usuarioRepository.Atualizar(usuarioId, usuario);
        }

        private int ObtemIdDoUsuarioNaUrl()
        {
            return int.Parse(Request.QueryString["id"]);
        }
    }
}