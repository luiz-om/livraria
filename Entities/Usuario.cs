namespace livraria.Entities;

public class Usuario : BaseEntity
{
    public Usuario() 
    :base()
    {
        
        
    }

    public string Nome { get; set; }
    public string  Email { get; set; }
}