using Microsoft.EntityFrameworkCore;

namespace ListaDeContatos2.DBContext
{
    public class ListaDBContext : DbContext
    {
        public ListaDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ListaDeContatos> listaDeContatos { get; set; }
    }
}
