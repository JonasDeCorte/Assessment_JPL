using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Manager
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("id")]
        public int ManagerId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        [JsonPropertyName("dob")]
        public string DateOfBirth { get; set; }

        [JsonIgnore]
        public int CountryId { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }
}