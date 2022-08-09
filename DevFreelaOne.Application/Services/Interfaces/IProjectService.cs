using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectsViewModel> GetAllProjects();
        ProjectDetailsViewModel GetProjectById(int id);
        int CreateProject(CreateProjectInputViewModel inputModel);
        void UpdateProject(UpdateProjectInputViewModel inputModel);
        void CreateComment(CreateCommentInputViewModel inputModel);
        void DeleteProject(int id);
        void Start(int id);
        void Finish(int id);        
    }
}
