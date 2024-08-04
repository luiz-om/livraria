using livraria.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria.Persistence.Mapping;

public class LivroMap : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        //tabela
        builder.ToTable("Livro");
        
        // chave primaria
        builder.HasKey(l => l.Id);
        
        //Idendity
        builder.Property(l => l.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        
        //relacionamento
      
        
    }
}