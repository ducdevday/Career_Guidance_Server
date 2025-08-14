using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Ward
    {
        public int WardId { get; set; }
        public string WardName { get; set; } = default!;
        public int DistrictId { get; set; }

        public District? District { get; set; }
    }
}
