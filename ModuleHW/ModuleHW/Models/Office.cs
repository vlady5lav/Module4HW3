using System.Collections.Generic;

namespace ModuleHW.Models
{
    public class Office
    {
        public Office()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
