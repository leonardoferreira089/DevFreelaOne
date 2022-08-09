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
        List<ProjectsViewModel> GetAllProjects(string query);
        ProjectDetailsViewModel GetProjectById(int id);
        int CreateProject(CreateProjectInputModel inputModel);
        void UpdateProject(UpdateProjectInputModel inputModel);
        void CreateComment(CreateCommentInputModel inputModel);
        void DeleteProject(int id);
        void Start(int id);
        void Finish(int id);        
    }
}
