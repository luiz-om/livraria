namespace livraria.Entities;

public class Usuario : BaseEntity
{
    public Usuario() 
    :base()
    {
        Emprestimos = new List<Emprestimo>();

    }

    public string Nome { get; set; }
    public string  Email { get; set; }

    public List<Emprestimo>? Emprestimos { get; set; }
}