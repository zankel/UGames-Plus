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
    public class GeneroController : ControllerBase
    {

        private readonly ILogger<GeneroController> _logger;

        // Declaration of the service used
        private IGeneroBusiness _generoBusiness;

        // Injection of an instance of IgeneroService
        // when creating an instance of generoController
        public GeneroController(ILogger<GeneroController> logger, IGeneroBusiness generoBusiness)
        {
            _logger = logger;
            _generoBusiness = generoBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/genero
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<GeneroVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_generoBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/genero/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(GeneroVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var genero = _generoBusiness.FindByID(id);
            if (genero == null) return NotFound();
            return Ok(genero);
        }

        // Maps POST requests to https://localhost:{port}/api/genero/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(GeneroVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] GeneroVO genero)
        {
            if (genero == null) return BadRequest();
            return Ok(_generoBusiness.Create(genero));
        }

        // Maps PUT requests to https://localhost:{port}/api/genero/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(GeneroVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] GeneroVO genero)
        {
            if (genero == null) return BadRequest();
            return Ok(_generoBusiness.Update(genero));
        }

        // Maps DELETE requests to https://localhost:{port}/api/genero/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _generoBusiness.Delete(id);
            return NoContent();
        }
    }
}
