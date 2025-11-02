using CadastroUsuarioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuarioAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
