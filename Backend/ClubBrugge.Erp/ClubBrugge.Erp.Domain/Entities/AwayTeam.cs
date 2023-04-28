using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class AwayTeam
    {
        [JsonIgnore]

        public int AwayTeamId { get; set; }

        [JsonPropertyName("away_team_name")]
        public string AwayTeamName { get; set; }

        [JsonPropertyName("away_team_gender")]
        public string AwayTeamGender { get; set; }

        [JsonPropertyName("away_team_youth")]
        public bool AwayTeamYouth { get; set; }

        [JsonPropertyName("away_team_group")]
        public string? AwayTeamGroup { get; set; }

        [JsonIgnore]
        public int CountryId { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("managers")]
        public List<Manager> AwayTeamManagers { get; set; } = new();

        public List<Match> AwayMatches { get; set; }
    }
}