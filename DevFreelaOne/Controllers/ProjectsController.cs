using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.Services.Interfaces;
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
        private readonly IProjectService _service;
        public ProjectsController(IProjectService service)
        {
            service = _service;
        }

        // api/projects?query=net core
        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var projects = _service.GetAllProjects(query);

            return Ok(projects);
        }

        //api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _service.GetProjectById(id);
            if(project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        //api/projects
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectInputModel inputModel)
        {
            if (inputModel.Description.Length < 50)
            {
                return BadRequest();
            }

            var id = _service.CreateProject(inputModel);


            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        //api/projects/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            if (inputModel.Description.Length < 50)
            {
                return BadRequest();
            }

            _service.UpdateProject(inputModel);

            return NoContent();
        }

        //api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteProject(id);

            return NoContent();
        }

        //api/projects/3/comments
        [HttpPut("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentInputModel inputModel)
        {
            _service.CreateComment(inputModel);

            return NoContent();
        }

        // api/projects/3/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _service.Start(id);

            return NoContent();
        }        

        //api/projects/3/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _service.Finish(id);

            return NoContent();
        }        

    }
}
