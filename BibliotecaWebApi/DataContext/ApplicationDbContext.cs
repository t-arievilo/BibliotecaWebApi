using BibliotecaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaWebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<LivroModel> Livros { get; set; }
       
    }
}
