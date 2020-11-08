using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Semita3.Models
{
    public class Project
    {
        [Display(Name = "Project ID")]
        [Required(ErrorMessage = "Project must have an ID.")]
        public int ProjectId { get; set; }

        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "Project must have a name.")]
        public string ProjectTitle { get; set; }
        [Display(Name = "Project Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime ProjectStartDate { get; set; }


        public IEnumerable<Ticket> Tickets { get; set; }

    }

}
