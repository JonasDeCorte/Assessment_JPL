using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Season
    {
        [JsonIgnore]
        public int SeasonId { get; set; }

        [JsonPropertyName("season_name")]
        public string Name { get; set; }

        public List<Match> Matches { get; set; }
    }
}