using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.ViewModels
{
    public class ProjectsViewModel
    {
        public ProjectsViewModel(int id,string title, DateTime createdAt)
        {
            Id = id;
            Title = title;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; private set; }
    }
}
