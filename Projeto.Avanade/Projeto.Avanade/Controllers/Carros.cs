using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Avanade.Domain;
using Projeto.Avanade.Repositorio;

namespace Projeto.Avanade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Carros : ControllerBase
    {
        //CRUD

        [HttpPost]
        public IActionResult CadastrarCarro([FromBody]Carro carro)
        {
            using(var ctx = new CarroContext())
            {
                ctx.Carros.Add(carro);
                ctx.SaveChanges();
            }

            return CreatedAtAction(nameof(LerCarro), new { IdCarro = carro.Id }, carro);
        }

        [HttpGet("{IdCarro}")]
        public IActionResult LerCarro(int IdCarro)
        {
            var ctx = new CarroContext();
            var car = ctx.Carros.FirstOrDefault(c => c.Id == IdCarro);

            if(car == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(car);
            }
        }

        [HttpDelete("{IdCarro}")]
        public IActionResult ExcluirCarro(int IdCarro)
        {
            var ctx = new CarroContext();
            ctx.Carros.Remove(ctx.Carros.FirstOrDefault(c => c.Id == IdCarro));
            ctx.SaveChanges();

            return Ok();
        }

        [HttpPut("{IdCarro}")]
        public IActionResult AlterarCarro(int IdCarro,Carro carro)
        {
            var ctx = new CarroContext();
            ctx.Entry(carro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();

            return Ok();
        }
    }
}
