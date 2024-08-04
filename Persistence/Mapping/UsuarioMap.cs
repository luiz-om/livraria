using livraria.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria.Persistence.Mapping;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        
        builder.HasKey(u => u.Id);
        
        //Idendity
        builder.Property(u => u.Id)
            .ValueGeneratedOnAdd() 
            .UseIdentityColumn();
        
      
    }
}