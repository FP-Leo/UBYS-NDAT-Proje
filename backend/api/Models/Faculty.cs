using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Faculty
    {
        
        public string FacultyName { get; set; }
        public string FacultyID { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }


        // Navigation Property
        public string UniId { get; set; }
        public University University { get; set; }   //One-to-Many relationship
        public ICollection<Department> Departments { get; set; } // One-to-Many

        // public User Dean { get; set; } // One-to-One relationship 
    }
}