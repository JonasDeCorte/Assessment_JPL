using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Stadium
    {
        [JsonIgnore]
        public int StadiumId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore]
        public int CountryId { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        public List<Match> Matches { get; set; }
    }
}