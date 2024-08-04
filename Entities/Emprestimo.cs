namespace livraria.Entities;

public class Emprestimo : BaseEntity
{
    public int IdUser { get; set; }
    public Usuario User { get; set; }
    public int IdLivro { get; set; }
    public Livro Livro { get; set; }

    public DateTime DataEmprestimo { get; set; }
    
    
}