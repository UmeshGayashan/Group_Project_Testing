using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group.View;

namespace Group.Model
{
    public class Patient
    {
        [Key]
        public int Pid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public string Gender { get; set; }
        public string Ward { get; set; }

        //public string? PhoneNo { get; set; }
        public string? MedicalPriorities { get; set; }


    }
}
