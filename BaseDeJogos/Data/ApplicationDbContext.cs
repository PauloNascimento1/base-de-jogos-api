using BaseDeJogos.Model;
using Microsoft.EntityFrameworkCore;

namespace BaseDeJogos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<JogoModel> Jogo { get; set; }
    }


}
