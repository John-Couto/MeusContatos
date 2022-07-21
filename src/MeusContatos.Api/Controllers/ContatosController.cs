using MeusContatos.Api.Entities;
using MeusContatos.Api.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace MeusContatos.Api.Controllers
{
    // REST API
    [ApiController]
    [Route("[controller]")]
    public class ContatosController : ControllerBase
    {
        private ClasseGeraldbContext dbContext;

        public ContatosController()
        {
            dbContext = new ClasseGeraldbContext();
        }
        //CREATE
        [HttpPost]
        public IActionResult Create(
           [FromBody] Contato contato)
        {
            dbContext.Contatos?.Add(contato);
            dbContext.SaveChanges();

            return Ok(contato);
        }

        // READ
        [HttpGet]
        public IActionResult Read()
        {
            var contatos = dbContext.Contatos.ToList();

            return Ok(contatos);
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(
            [FromRoute] int id,
            [FromBody] Contato contatoAtualizar)
        {
            var contato = dbContext.Contatos?.Find(id);
            contato.Nome = contatoAtualizar.Nome;
            contato.Telefone = contatoAtualizar.Telefone;
            dbContext.Contatos?.Update(contato);
            dbContext.SaveChanges();

            return Ok(contato);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(
            [FromRoute] int id)
        {
            var contato = dbContext.Contatos.Find(id);
            dbContext.Contatos.Remove(contato);
            dbContext.SaveChanges();

            return Ok(contato);
        }
    }
}
