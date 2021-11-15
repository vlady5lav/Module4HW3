using System.Collections.Generic;

namespace ModuleHW.DataAccess.Models
{
    public class Office
    {
        public Office()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
