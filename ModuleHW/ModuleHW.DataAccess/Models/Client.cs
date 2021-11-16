using System.Collections.Generic;

namespace ModuleHW.DataAccess.Models
{
    public class Client
    {
        public Client()
        {
            Projects = new List<Project>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public List<Project> Projects { get; set; }
    }
}
