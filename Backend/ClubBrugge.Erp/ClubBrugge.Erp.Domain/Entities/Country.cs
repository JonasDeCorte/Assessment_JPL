using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Country
    {
        [JsonIgnore]
        public int CountryId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        public List<AwayTeam> AwayTeams { get; set; }
        public List<Competition> Competitions { get; set; }
        public List<HomeTeam> HomeTeams { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Referee> Referees { get; set; }
        public List<Stadium> Stadiums { get; set; }
    }
}