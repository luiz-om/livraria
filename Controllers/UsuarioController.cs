using livraria.Entities;
using livraria.Models;
using livraria.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

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
        var usuario = _dbContext.Usuarios
            .Include(u => u.Emprestimos)
            .ThenInclude(l => l.Livro)
            .ToList();
        if (usuario.IsNullOrEmpty())
        {
            return BadRequest();
        }

        var model = usuario.Select(UsuarioViewModel.FromEntity).ToList();
        return Ok(model);
    }

    [HttpGet("{id}/qtd")]
    public IActionResult QuantidadeEmprestimos(int id)
    {
        var usuario = _dbContext.Usuarios
            .Include(u => u.Emprestimos)
            .SingleOrDefault(u => u.Id ==id);
        if (usuario is null)
        {
            return BadRequest();
        }
        var model = UsuarioGetIdViewModel.FromEntity(usuario);
        
        return Ok(model);
    }
    
    [HttpPost]
    public IActionResult Post(CreateUsuarioInputModel model)
    {
        var usuario = model.ToEntity();
        _dbContext.Usuarios.Add(usuario);
        _dbContext.SaveChanges();
        
        return Ok(usuario.Id);
    }

    [HttpPut("{id}")]
    public IActionResult Edit(int id, Usuario usuario)
    {
        var usuarioAtualizado = _dbContext.Usuarios
            .Include(u=>u.Emprestimos)
            .SingleOrDefault(u => u.Id == id);

        if (usuarioAtualizado is null)
        {
            return BadRequest();
        }

        if (!usuarioAtualizado.Emprestimos.IsNullOrEmpty())
        {
            return BadRequest("Não é possivel alterar o usuario, existe emprestimos em aberto");
        }

        usuarioAtualizado.Email = usuario.Email;
        usuarioAtualizado.Nome = usuario.Nome;

        _dbContext.Usuarios.Update(usuarioAtualizado);
        _dbContext.SaveChanges();
        
        return NoContent();
    }
}