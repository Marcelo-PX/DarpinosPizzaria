using Microsoft.AspNetCore.Mvc;
using DarpinosPizzaria.Models;
using System.Linq;

namespace DarpinosPizzaria.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;
        public ClienteController(DataContext context) => _context = context;

        [HttpGet]//GET: /api/cliente/listar
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Clientes.ToList());

        [HttpPost]//POST: /api/cliente/cadastrar
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return Created("", cliente);
        }

        [HttpGet]//GET: /api/cliente/buscar/{cpf} **posteriormente id
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            Cliente cliente = _context.Clientes.
                FirstOrDefault(x => x.Cpf.Equals(cpf));

            return cliente != null ? Ok(cliente) : NotFound();
        }

        [HttpDelete]//DELETE: /api/cliente/deletar/{id}
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            
            if(cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();

                return Ok(cliente);
            }
            return NotFound();
        }

        [HttpPatch]//PACTH: /api/cliente/alterar
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Cliente cliente)
        {
            try
            {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                return Ok(cliente);
            }
            catch
            {
                return NotFound();
            }    
        }
    }
}