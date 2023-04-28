using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class CompetitionStage
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Match> Matches { get; set; }
    }
}