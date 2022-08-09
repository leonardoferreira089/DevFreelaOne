using DevFreelaOne.Application.Services.Interfaces;
using DevFreelaOne.Application.ViewModels;
using DevFreelaOne.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevFreelaOne.Application.Services.Implementarions
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaOneDbContext _context;
        public SkillService(DevFreelaOneDbContext context)
        {
            _context = context;
        }

        public List<SkillsViewModel> GetSkills()
        {
            var skill = _context.Skills;
            var skillVm = skill.Select(s => new SkillsViewModel(s.Id, s.Description)).ToList();

            return skillVm;
        }
    }
}
