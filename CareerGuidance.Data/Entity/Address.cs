using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Address : AuditableEntity
    {
        public int Id { get; set; }
        public string? StreetNo { get; set; }
        public string WardId { get; set; }
        public string WardName { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }   

        public Mentor? Mentor { get; set; }
        public Company? Company { get; set; }
        public School? School { get; set; }
        

        public Tour? Tour { get; set; }
        public Workshop? Workshop { get; set; }
    }
}
