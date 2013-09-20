using System.Collections.Generic;
using EntityFrameworkExample.Entidades;

namespace EntityFrameworkExample.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario ObterPorId(int id);
        IEnumerable<Usuario> ObterTodos();
        IEnumerable<Usuario> ObterAtivos();
        IEnumerable<Usuario> ObterPorNome(string nomeFiltrado);
        void Deletar(int id);
        void DelecaoLogica(int id);
        void Atualizar(int id, Usuario usuarioNovo);
        void Salvar(Usuario usuario);
    }
}