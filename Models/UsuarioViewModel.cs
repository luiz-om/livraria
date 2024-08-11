using livraria.Entities;

namespace livraria.Models;

public class UsuarioViewModel
{
 
    public UsuarioViewModel(string  nome, string  email, List<Emprestimo> emprestimos)
    {
        Nome = nome;
        Email = email;
        Emprestimos = emprestimos.Select(e => e.Livro.Titulo ).ToList();
    }

  
    public string Nome { get; set; }
    public string  Email { get; set; }
    public List<string> Emprestimos { get; set; }
    


    public static  UsuarioViewModel FromEntity(Usuario usuario)
        => new UsuarioViewModel(usuario.Nome, usuario.Email, usuario.Emprestimos);
}