using DevFreelaOne.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreelaOne.API.Controllers
{
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _service;
        public SkillsController(ISkillService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var skills = _service.GetSkills();
            return Ok(skills);
        }
    }
}
