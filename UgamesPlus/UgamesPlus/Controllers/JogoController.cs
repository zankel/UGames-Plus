using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Controllers
{

    [ApiVersion("1")]
    [ApiController]
    //[Authorize("Bearer")]
    [Route("api/[controller]")]
    public class JogoController : ControllerBase
    {

        private readonly ILogger<JogoController> _logger;

        // Declaration of the service used
        private IJogoBusiness _jogoBusiness;

        // Injection of an instance of IJogoService
        // when creating an instance of JogoController
        public JogoController(ILogger<JogoController> logger, IJogoBusiness jogoBusiness)
        {
            _logger = logger;
            _jogoBusiness = jogoBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/Jogo
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<JogoVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_jogoBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/Jogo/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(JogoVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var Jogo = _jogoBusiness.FindByID(id);
            if (Jogo == null) return NotFound();
            return Ok(Jogo);
        }

        // Maps POST requests to https://localhost:{port}/api/Jogo/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(JogoVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] JogoVO Jogo)
        {
            if (Jogo == null) return BadRequest();
            return Ok(_jogoBusiness.Create(Jogo));
        }

        // Maps PUT requests to https://localhost:{port}/api/Jogo/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(JogoVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] JogoVO Jogo)
        {
            if (Jogo == null) return BadRequest();
            return Ok(_jogoBusiness.Update(Jogo));
        }

        // Maps DELETE requests to https://localhost:{port}/api/Jogo/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _jogoBusiness.Delete(id);
            return NoContent();
        }
    }
}
