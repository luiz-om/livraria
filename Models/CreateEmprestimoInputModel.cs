using livraria.Entities;

namespace livraria.Models;

public class CreateEmprestimoInputModel
{
    public int IdUser { get; set; }
    public int IdLivro { get; set; }


    public Emprestimo ToEntity()
        => new(IdUser, IdLivro);
}