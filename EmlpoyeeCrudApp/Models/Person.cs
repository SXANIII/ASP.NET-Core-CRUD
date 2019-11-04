using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmlpoyeeCrudApp.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
    }
}
