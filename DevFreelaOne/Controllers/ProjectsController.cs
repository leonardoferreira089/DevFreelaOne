using DevFreelaOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreelaOne.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option, ExampleClass exampleClass)
        {
            exampleClass.Name = "Qualquer valor escrito";
            _option = option.Value;
        }

        // api/projects?query=net core
        [HttpGet]
        public IActionResult GetAll(string query)
        {
            return Ok();
        }

        //api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //not Found

            return Ok();
        }

        //api/projects
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Description.Length < 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //api/projects/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length < 50)
            {
                return BadRequest();
            }

            return NoContent();
        }

        //api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // return NotFound():

            return NoContent();
        }

        //api/projects/3/comments
        [HttpPut("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        // api/projects/3/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }        

        //api/projects/3/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }        

    }
}
