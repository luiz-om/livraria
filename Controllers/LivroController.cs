using livraria.Entities;
using livraria.Models;
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var livro = _dbContext.Livros.SingleOrDefault(l => l.Id == id);
            if (livro is null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Post(Livro livro)
        {
            _dbContext.Livros.Add(livro);
            _dbContext.SaveChanges();

            return Ok(livro.Id);
        }

        [HttpPut]
        public IActionResult Put(string isbn, UpdateLivroInputModel model)
        {
            var livronovo = _dbContext.Livros.First(i => i.ISBN == isbn);

            if (livronovo is null)
            {
                return NotFound();
            }
            livronovo.Update(model);
            _dbContext.Livros.Update(livronovo);
            _dbContext.SaveChanges();
            
            
            return Ok();
        }
    }