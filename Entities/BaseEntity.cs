namespace livraria.Entities;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        DataCriacao = DateTime.Now;
    }
    public int Id { get; private set; }
    public DateTime DataCriacao { get; private set; }
}