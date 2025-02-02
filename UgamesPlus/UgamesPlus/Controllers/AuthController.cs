﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UgamesPlus.Business;
using UgamesPlus.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UgamesPlus.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UsuarioVO usuario)
        {
            if (usuario == null) return BadRequest("Ivalid client request");
            var token = _loginBusiness.ValidateCredentials(usuario);
            if (token == null) return Unauthorized();
            return Ok(token);
        }

        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh([FromBody] TokenVO tokenVo)
        {
            if (tokenVo is null) return BadRequest("Ivalid client request");
            var token = _loginBusiness.ValidateCredentials(tokenVo);
            if (token == null) return BadRequest("Ivalid client request");
            return Ok(token);
        }


        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        {
            var username = User.Identity.Name;
            var result = _loginBusiness.RevokeToken(username);

            if (!result) return BadRequest("Ivalid client request");
            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(UsuarioVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
       
        public IActionResult Post([FromBody] UsuarioVO usuario)
        {
            if (usuario == null) return BadRequest();
            return Ok(_loginBusiness.Create(usuario));
        }
    }
}
