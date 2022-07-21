using MeusContatos.Api.Entities;
using MeusContatos.Api.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace MeusContatos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperHeroiController : ControllerBase
    {
        private ClasseGeraldbContext dbContext;

        public SuperHeroiController()
        {
            dbContext = new ClasseGeraldbContext();
        }

        [HttpPost]
        public IActionResult Create(
           [FromBody] SuperHeroi Toby)
        {
            dbContext?.SuperHeroi?.Add(Toby);
            dbContext?.SaveChanges();

            return Ok(Toby);
        }

        [HttpGet]

        public IActionResult Read()
        {
            var herois = dbContext.SuperHeroi?.ToList();

            return Ok(herois);
        }
        [HttpPut("{id}")]
        public IActionResult Update(
            [FromRoute] int id,
            [FromBody] SuperHeroi atualizaHeroi)
        {
            var heroi = dbContext.SuperHeroi.Find(id);
            heroi.Poder = atualizaHeroi.Poder;
            heroi.Name = atualizaHeroi.Name;
            dbContext.Update(heroi);
            dbContext.SaveChanges();
            return Ok(heroi);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(
            [FromRoute] int id)
        {
            var heroi = dbContext.SuperHeroi?.Find(id);
            dbContext.SuperHeroi?.Remove(heroi);
            dbContext.SaveChanges();

            return Ok(heroi);
        }


    }
}
