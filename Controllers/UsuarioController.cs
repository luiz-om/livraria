using livraria.Entities;
using livraria.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Controllers;

[ApiController]
[Route("api/usuario")]
public class UsuarioController : ControllerBase
{
    private readonly LivrariaDbContext _dbContext;

    public UsuarioController(LivrariaDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var livro = _dbContext.Usuarios.ToList();

        return Ok(livro);
    }

    [HttpPost]
    public IActionResult post(Usuario usuario)
    {

        _dbContext.Usuarios.Add(usuario);
        _dbContext.SaveChanges();
        
        return Ok(usuario.Id);
    }
}