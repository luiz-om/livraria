using livraria.Entities;

namespace livraria.Models;

public class UsuarioGetIdViewModel
{
    public UsuarioGetIdViewModel(string nome, List<Emprestimo> ee)
    {
        Nome = nome;
        QuantidadeEmprestimos = ee.Count;
    }

  
    public string Nome { get; set; }
    public int QuantidadeEmprestimos { get; set; }
    


    public static UsuarioGetIdViewModel FromEntity(Usuario usuario)
        => new UsuarioGetIdViewModel(usuario.Nome, usuario.Emprestimos);
}