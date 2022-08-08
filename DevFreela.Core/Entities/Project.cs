using DevFreelaOne.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelance, decimal totalCoast)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelance = idFreelance;
            TotalCoast = totalCoast;

            CreatedAt = DateTime.Now;
            Status = ProjectStatus.Created;
            Comments = new List<ProjectComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelance { get; private set; }
        public decimal TotalCoast { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }
        public ProjectStatus Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Cancel()
        {
            if(Status == ProjectStatus.Created || Status == ProjectStatus.InProgress)
            {
                Status = ProjectStatus.Cancelled;
            }
        }

        public void Start()
        {
            if(Status == ProjectStatus.Created)
            {
                Status = ProjectStatus.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Finish()
        {
            if(Status == ProjectStatus.InProgress)
            {
                Status = ProjectStatus.Finished;
                FinishedAt = DateTime.Now;
            }
        }

        public void Update(string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCoast = totalCost;
        }
    }
}
