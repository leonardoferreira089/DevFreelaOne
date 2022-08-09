using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.Services.Interfaces;
using DevFreelaOne.Application.ViewModels;
using DevFreelaOne.Core.Entities;
using DevFreelaOne.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.Services.Implementarions
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaOneDbContext _context;
        public ProjectService(DevFreelaOneDbContext context)
        {
            _context = context;
        }

        public void CreateComment(CreateCommentInputViewModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);

            _context.Comments.Add(comment);
        }

        public int CreateProject(CreateProjectInputViewModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelance, inputModel.TotalCost);
            _context.Add(project);

            return project.Id;
        }

        public void DeleteProject(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            project.Cancel();
        }

        public void Finish(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            project.Finish();
        }

        public List<ProjectsViewModel> GetAllProjects()
        {
            var projects = _context.Projects;
            var projectsVM = projects.Select(p => new ProjectsViewModel(p.Id, p.Title, p.CreatedAt)).ToList();

            return projectsVM;
        }

        public ProjectDetailsViewModel GetProjectById(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            var projectVM = new ProjectDetailsViewModel(project.Id, project.Title, project.Description, project.TotalCoast, project.StartedAt, project.FinishedAt);

            return projectVM;
        }

        public void Start(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            project.Start();
        }

        public void UpdateProject(UpdateProjectInputViewModel inputModel)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == inputModel.Id);
        }
    }
}
