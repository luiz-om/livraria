using livraria.Entities;
using livraria.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace livraria.Persistence;

public class LivrariaDbContext(DbContextOptions<LivrariaDbContext> options) : DbContext(options)
{
  

    public DbSet<Usuario> Usuarios { get; set;  }
    public DbSet<Emprestimo> Emprestimos { get; set; }
    public DbSet<Livro> Livros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LivroMap());
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new EmprestimoMap());
        
    
        
    }
    
    
}