using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Dtos.Nested
{
    public class WardDto
    {
        [JsonPropertyName("ward_id")] public int WardId { get; set; }
        [JsonPropertyName("ward_name")] public string WardName { get; set; } = default!;
    }
}
