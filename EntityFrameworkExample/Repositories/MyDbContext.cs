using System.Data.Entity;
using EntityFrameworkExample.Entidades;

namespace EntityFrameworkExample.Repositories
{
    public class MyDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}