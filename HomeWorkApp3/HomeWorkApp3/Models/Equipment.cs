using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWorkApp3.Models
{
    public class Equipment
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Category { get; set; }

        [Required]
        [Display(Name = "Assigned to")]
        public string AssignedTo { get; set; }
    }
}