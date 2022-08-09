using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.Services.Interfaces;
using DevFreelaOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreelaOne.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        //api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _service.GetUserById(id);
            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        //api/users
        [HttpPost]
        public IActionResult Post([FromBody]CreateUserInputModel inputModel)
        {
            if(inputModel == null)
            {
                return BadRequest();
            }
            var id = _service.CreateUser(inputModel);

            return CreatedAtAction(nameof(GetById), new { Id = id }, inputModel);
        }

        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id,[FromBody] LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
