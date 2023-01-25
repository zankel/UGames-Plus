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
    [Authorize("Bearer")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PostController : ControllerBase
    {

        private readonly ILogger<PostController> _logger;

        // Declaration of the service used
        private IPostBusiness _postBusiness;

        // Injection of an instance of IPostService
        // when creating an instance of PostController
        public PostController(ILogger<PostController> logger, IPostBusiness postBusiness)
        {
            _logger = logger;
            _postBusiness = postBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/Post
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<PostVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_postBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/Post/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var Post = _postBusiness.FindByID(id);
            if (Post == null) return NotFound();
            return Ok(Post);
        }

        // Maps POST requests to https://localhost:{port}/api/Post/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PostVO Post)
        {
            if (Post == null) return BadRequest();
            return Ok(_postBusiness.Create(Post));
        }

        // Maps PUT requests to https://localhost:{port}/api/Post/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        //[TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PostVO Post)
        {
            if (Post == null) return BadRequest();
            return Ok(_postBusiness.Update(Post));
        }

        // Maps DELETE requests to https://localhost:{port}/api/Post/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _postBusiness.Delete(id);
            return NoContent();
        }
    }
}
