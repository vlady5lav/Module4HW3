using System;
using System.Collections.Generic;

namespace ModuleHW.DataAccess.Models
{
    public class Employee
    {
        public Employee()
        {
            EmployeeProject = new List<EmployeeProject>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; }
    }
}
