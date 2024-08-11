using livraria.Entities;

namespace livraria.Models;

public class CreateUsuarioInputModel
{
    public string Nome { get; set; }
    public string  Email { get; set; }


    public Usuario ToEntity()
        => new(Nome, Email);

}