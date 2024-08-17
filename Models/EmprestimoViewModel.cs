using livraria.Entities;

namespace livraria.Models;

public class EmprestimoViewModel
{
    public EmprestimoViewModel(string nameUser, string nameBook, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        NameUser = nameUser;
        NameBook = nameBook;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }

    public string NameUser { get; set; }
    
    public string NameBook { get; set; }

    public DateTime DataEmprestimo { get; set; }

    public DateTime DataDevolucao { get; set; }

    public static EmprestimoViewModel FromEntity(Emprestimo emprestimo)
        => new EmprestimoViewModel(emprestimo.User.Nome, emprestimo.Livro.Titulo, emprestimo.DataEmprestimo, emprestimo.DataDevolucao);
}