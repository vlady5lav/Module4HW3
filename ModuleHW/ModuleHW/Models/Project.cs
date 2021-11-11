using System;
using System.Collections.Generic;

namespace ModuleHW.Models
{
    public class Project
    {
        public Project()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; } = new List<EmployeeProject>();
    }
}
