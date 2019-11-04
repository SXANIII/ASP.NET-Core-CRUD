using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmlpoyeeCrudApp.Models
{
    public class EmployeeViewModel
    {
        [Key]
        
        public int EmployeeId { get; set;}

        [Display(Name ="Employee Number")]
        public string EmployeeNum { get; set; }
        [Display(Name ="Date Employed")]
        public DateTime EmployeeDate { get;set;}
        [Display(Name ="Date Terminated")]
        public Nullable <System.DateTime> TerminatedDate { get; set; }

        
        public int PersonId { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
