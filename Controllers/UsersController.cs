﻿using DevFreelaOne.Models;
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
        public UsersController(ExampleClass exampleClass)
        {

        }

        //api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {            
            return Ok();
        }

        //api/users
        [HttpPost]
        public IActionResult Post([FromBody]CreateUserModel createUser)
        {
            return CreatedAtAction(nameof(GetById), new { Id = 1 }, createUser);
        }

        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id,[FromBody] LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
