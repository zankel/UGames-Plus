using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UgamesPlus.Business;
using UgamesPlus.Data.VO;
using System.Collections.Generic;

namespace UgamesPlus.Controllers
{

    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ComentarioController : ControllerBase
    {

        private readonly ILogger<ComentarioController> _logger;

        // Declaration of the service used
        private IComentarioBusiness _comentarioBusiness;

        // Injection of an instance of IComentarioService
        // when creating an instance of ComentarioController
        public ComentarioController(ILogger<ComentarioController> logger, IComentarioBusiness comentarioBusiness)
        {
            _logger = logger;
            _comentarioBusiness = comentarioBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/Comentario
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<ComentarioVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_comentarioBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/Comentario/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(ComentarioVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var comentario = _comentarioBusiness.FindByID(id);
            if (comentario == null) return NotFound();
            return Ok(comentario);
        }

        // Maps Comentario requests to https://localhost:{port}/api/Comentario/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(ComentarioVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] ComentarioVO comentario)
        {
            if (comentario == null) return BadRequest();
            return Ok(_comentarioBusiness.Create(comentario));
        }

        // Maps PUT requests to https://localhost:{port}/api/Comentario/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(ComentarioVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] ComentarioVO comentario)
        {
            if (comentario == null) return BadRequest();
            return Ok(_comentarioBusiness.Update(comentario));
        }

        // Maps DELETE requests to https://localhost:{port}/api/Comentario/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _comentarioBusiness.Delete(id);
            return NoContent();
        }
    }
}
