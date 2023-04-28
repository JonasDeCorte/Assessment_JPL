using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class HomeTeam
    {
        [JsonIgnore]
        public int HomeTeamId { get; set; }

        [JsonPropertyName("home_team_name")]
        public string HomeTeamName { get; set; }

        [JsonPropertyName("home_team_gender")]
        public string HomeTeamGender { get; set; }

        [JsonPropertyName("home_team_youth")]
        public bool HomeTeamYouth { get; set; }

        [JsonPropertyName("home_team_group")]
        public string? HomeTeamGroup { get; set; }

        [JsonIgnore]
        public int CountryId { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("managers")]
        public List<Manager> HomeTeamManagers { get; set; } = new();

        public List<Match> HomeMatches { get; set; }
    }
}