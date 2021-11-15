using System;
using System.Collections.Generic;

namespace ModuleHW.DataAccess.Models
{
    public class Project
    {
        public Project()
        {
            EmployeeProject = new List<EmployeeProject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; }
    }
}
