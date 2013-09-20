using System;

namespace EntityFrameworkExample.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            Ativo = true;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}