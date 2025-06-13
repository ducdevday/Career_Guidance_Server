using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Company : User
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int YearOfExperience { get; set; }
    }
}
