using System.Runtime.Serialization;

namespace livraria.Entities;

public class Emprestimo : BaseEntity
{
    public Emprestimo(int idUser, int idLivro)
    {
        IdUser = idUser;
        IdLivro = idLivro;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = DataEmprestimo.AddDays(10);
    }
    public int IdUser { get; set; }
    public Usuario User { get; set; }
    public int IdLivro { get; set; }
    public Livro Livro { get; set; }


    public DateTime DataEmprestimo { get; set; }

    public DateTime DataDevolucao { get; set; }
 
    
    
}