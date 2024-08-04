using livraria.Entities;
using livraria.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Controllers;

[ApiController]
[Route("api/livro")]
public class LivroController : ControllerBase
{
    private readonly LivrariaDbContext _dbContext;

    public LivroController(LivrariaDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var livro = _dbContext.Livros.ToList();

        return Ok(livro);
    }

    [HttpPost]
    public IActionResult post(Livro livro)
    {

        _dbContext.Livros.Add(livro);
        _dbContext.SaveChanges();
        
        return Ok(livro.Id);
    }
    
    
}