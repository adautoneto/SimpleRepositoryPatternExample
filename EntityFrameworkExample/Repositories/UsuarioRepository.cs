using System.Collections.Generic;
using System.Linq;
using EntityFrameworkExample.Entidades;

namespace EntityFrameworkExample.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MyDbContext contexto;        

        public UsuarioRepository(MyDbContext contexto)
        {
            this.contexto = contexto;
        }

        public Usuario ObterPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return contexto.Usuarios.ToList();
        }

        public IEnumerable<Usuario> ObterAtivos()
        {
            return contexto.Usuarios.Where(usuario => usuario.Ativo).ToList();
        }

        public IEnumerable<Usuario> ObterPorNome(string nomeFiltrado)
        {
            return contexto.Usuarios.Where(usuario => usuario.Nome.ToLower().Contains(nomeFiltrado.ToLower())).ToList();
        }

        public void Deletar(int id)
        {
            var usuario = ObterPorId(id);
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

        public void DelecaoLogica(int id)
        {
            var usuario = ObterPorId(id);
            usuario.Ativo = false;
            contexto.SaveChanges();
        }

        public void Atualizar(int id, Usuario usuarioNovo)
        {
            var usuarioAntigo = ObterPorId(id);
            usuarioAntigo.Nome = usuarioNovo.Nome;
            usuarioAntigo.Sobrenome = usuarioNovo.Sobrenome;
            usuarioAntigo.Ativo = usuarioNovo.Ativo;            
            contexto.SaveChanges();
        }

        public void Salvar(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }        
    }
}