using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    [NotMapped]
    public class Metadata
    {
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        [JsonPropertyName("shot_fidelity_version")]
        public string ShotFidelityVersion { get; set; }

        [JsonPropertyName("xy_fidelity_version")]
        public string XyFidelityVersion { get; set; }
    }
}