using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Dtos.Nested
{
    public class DistrictDto
    {
        [JsonPropertyName("district_id")] public int DistrictId { get; set; }
        [JsonPropertyName("district_name")] public string DistrictName { get; set; } = default!;
    }
}
