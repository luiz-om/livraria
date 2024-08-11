using livraria.Entities;

namespace livraria.Models;

public class UsuarioViewModel
{
    public UsuarioViewModel(string nome, List<Emprestimo> ee)
    {
        Nome = nome;
        QuantidadeEmprestimos = ee.Count;
    }

  
    public string Nome { get; set; }
    public int QuantidadeEmprestimos { get; set; }
    


    public static UsuarioViewModel FromEntity(Usuario usuario)
        => new UsuarioViewModel(usuario.Nome, usuario.Emprestimos);
}