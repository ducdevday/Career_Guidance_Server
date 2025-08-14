using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; } = default!;
        public string? ProvinceType { get; set; }

        public ICollection<District> Districts { get; set; } = new List<District>();
    }
}
