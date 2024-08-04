using livraria.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria.Persistence.Mapping;

public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
{
    public void Configure(EntityTypeBuilder<Emprestimo> builder)
    {
        builder.ToTable("Emprestimo");
        
        // chave primaria 
        builder.HasKey(e => e.Id);
        
        
        //Idendity
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.HasOne(l => l.User)
            .WithMany(l => l.Emprestimos)
            .HasForeignKey(l=> l.IdUser);

        builder.HasOne(l => l.Livro)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
    }
}