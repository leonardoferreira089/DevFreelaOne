using DevFreelaOne.Application.ViewModels;
using DevFreelaOne.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillsViewModel> GetSkills();
    }
}
