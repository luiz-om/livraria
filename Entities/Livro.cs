using livraria.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace livraria.Entities;

public class Livro : BaseEntity
{
    public Livro()
    :base()
    { }

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }

    public List<Emprestimo> Emprestimos { get; set; }


    public void Update(UpdateLivroInputModel livro)
    {
        Titulo = livro.Titulo;
        Autor = livro.Autor;
        ISBN = livro.ISBN;
        AnoPublicacao = livro.AnoPublicacao;
    }
}