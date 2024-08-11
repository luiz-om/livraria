using livraria.Entities;
using livraria.Models;
using livraria.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livraria.Controllers;

[ApiController]
[Route("api/emprestimo")]
public class EmprestimoController : ControllerBase
{
    private readonly LivrariaDbContext _dbContext;

    public EmprestimoController(LivrariaDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var emprestimo = _dbContext.Emprestimos
            .Include(e => e.User)
            .Include(e => e.Livro)
            .ToList();

        return Ok(emprestimo);
    }

    [HttpPost]
    public IActionResult Post(CreateEmprestimoInputModel model)
    {
        var emrpestimo = model.ToEntity();
        _dbContext.Emprestimos.Add(emrpestimo);
        _dbContext.SaveChanges();
        
        return Ok(emrpestimo.Id);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var emprestimo = _dbContext.Emprestimos.First(e => e.Id==id);
        _dbContext.Emprestimos.Remove(emprestimo);
        _dbContext.SaveChanges();
        return Ok(emprestimo);
    }
}