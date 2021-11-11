using System;

namespace ModuleHW.Models
{
    public class EmployeeProject
    {
        public EmployeeProject()
        {
        }

        public int Id { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
