namespace livraria.Entities;

public class Livro : BaseEntity
{
    public Livro()
    :base()
    {
        
    }

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }

    public List<Emprestimo> Emprestimos { get; set; }

    
}