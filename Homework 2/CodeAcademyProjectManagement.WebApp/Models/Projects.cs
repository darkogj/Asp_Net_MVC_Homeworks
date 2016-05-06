using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAcademyProjectManagement.WebApp.Models
{
    public class Projects
    {
        public static List<Project> GetAll()
        {
            List<Project> projects = new List<Project>();
            projects.Add(new Project
            {
                ID = 1,
                Name = "A",
                Estimate = 100,
                Description = "Project A Description"
            });

            projects.Add(new Project
            {
                ID = 2,
                Name = "B",
                Estimate = 300,
                Description = "Project B Description"
            });

            projects.Add(new Project
            {
                ID = 3,
                Name = "C",
                Estimate = 400,
                Description = "Project C Description"
            });

            projects.Add(new Project
            {
                ID = 4,
                Name = "D",
                Estimate = 700,
                Description = "Project D Description"
            });

            return projects;
        }
    }

    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Estimate { get; set; }
    }
}