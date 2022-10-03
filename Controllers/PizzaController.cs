using Microsoft.AspNetCore.Mvc;
using DarpinosPizzaria.Models;
using System.Linq;

namespace DarpinosPizzaria.Controllers
{
    [ApiController]
    [Route("api/pizza")]
    public class PizzaController : ControllerBase
    {
        private readonly DataContext _context;
        public PizzaController(DataContext context) => _context = context;

        [HttpGet]//GET: /api/pizza/listar
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Pizzas.ToList());

        [HttpPost]//POST: /api/pizza/cadastrar
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();

            return Created("", pizza);
        }

        [HttpGet]//GET: /api/pizza/buscar/{sabor}
        [Route("buscar/{sabor}")]
        public IActionResult Buscar([FromRoute] string sabor)
        {
            Pizza pizza = _context.Pizzas.
                FirstOrDefault(x => x.Sabor.Equals(sabor));

            return pizza != null ? Ok(pizza) : NotFound();
        }

        [HttpDelete]//DELETE: /api/pizza/deletar/{id}
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Pizza pizza = _context.Pizzas.Find(id);

            if (pizza != null)
            {
                _context.Pizzas.Remove(pizza);
                _context.SaveChanges();

                return Ok(pizza);
            }
            return NotFound();
        }

        [HttpPatch]//PACTH: /api/pizza/alterar
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Pizza pizza)
        {
            try
            {
                _context.Pizzas.Update(pizza);
                _context.SaveChanges();
                return Ok(pizza);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}