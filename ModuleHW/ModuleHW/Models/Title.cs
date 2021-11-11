using System.Collections.Generic;

namespace ModuleHW.Models
{
    public class Title
    {
        public Title()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
