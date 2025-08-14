using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class District
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; } = default!;
        public int ProvinceId { get; set; }

        public Province? Province { get; set; }
        public ICollection<Ward> Wards { get; set; } = new List<Ward>();
    }
}
