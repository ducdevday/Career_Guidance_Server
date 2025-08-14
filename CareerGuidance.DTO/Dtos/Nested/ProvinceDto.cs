using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Dtos.Nested
{
    public class ProvinceDto
    {
        [JsonPropertyName("province_id")] public int ProvinceId { get; set; }
        [JsonPropertyName("province_name")] public string ProvinceName { get; set; } = default!;
        [JsonPropertyName("province_type")] public string? ProvinceType { get; set; }
    }

}
