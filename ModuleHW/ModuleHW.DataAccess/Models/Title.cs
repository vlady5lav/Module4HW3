using System.Collections.Generic;

namespace ModuleHW.DataAccess.Models
{
    public class Title
    {
        public Title()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
