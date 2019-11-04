using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmlpoyeeCrudApp.Models
{
    public class Employee
    {
       [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string EmployeeNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime EmployeeDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime TerminatedDate { get; set; }

        // Foreign key for Person table //
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        
    }
}
