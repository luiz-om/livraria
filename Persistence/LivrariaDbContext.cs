using livraria.Entities;
using Microsoft.EntityFrameworkCore;

namespace livraria.Persistence;

public class LivrariaDbContext : DbContext
{
    public LivrariaDbContext()
    :base()
    {
    }

    public DbSet<Usuario> Usuarios { get; set;  }
    
    
}