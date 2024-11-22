using GSNet24.Model;
using GSNet24.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GSNet24.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AparelhoController : Controller
    {
        private readonly IAparelhoRepository _aparelhoRepository;


        public AparelhoController(IAparelhoRepository aparelhoRepository)
        {
            _aparelhoRepository = aparelhoRepository;

        }

        [HttpGet]
        [Route("List")]
        public ActionResult Get()
        {
            var ender = _aparelhoRepository.List();

            if (ender == null)
                return NotFound("Não Encontrado");

            return Ok(ender);
        }


        [HttpPost]
        [Route("Add")]
        public ActionResult Post([FromBody] AparelhoModel ende)
        {

            if (ende == null)
                return BadRequest();
            _aparelhoRepository.Add(ende);


            return Ok("Adicionado com sucesso");
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Put([FromBody] AparelhoModel ende)
        {
            if (ende == null)
                return BadRequest();

            var endeResponse = _aparelhoRepository.Update(ende);
            if (endeResponse.AparelhoId == 0)
                return BadRequest();

            return Ok(endeResponse);
        }

        [HttpDelete]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {

            if (id == 0)
                return BadRequest();

            var ender = _aparelhoRepository.Get(id);
            if (ender == null)
                return NoContent();

            var status = _aparelhoRepository.Delete(id);

            if (!status)
                return BadRequest();


            return Ok("Excluido com Sucesso");
        }
    }
}
