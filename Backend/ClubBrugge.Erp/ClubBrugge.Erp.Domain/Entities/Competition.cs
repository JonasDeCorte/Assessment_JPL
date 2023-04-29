using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Competition
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("competition_id")]
        public int CompetitionId { get; set; }

        [JsonPropertyName("competition_name")]
        public string Name { get; set; }

        public List<Match> Matches { get; set; }

        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }
    }
}