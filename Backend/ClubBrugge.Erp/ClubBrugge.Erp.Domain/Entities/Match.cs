using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class Match
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("match_id")]
        public int MatchId { get; set; }

        [JsonPropertyName("match_date")]
        public string MatchDate { get; set; }

        [JsonPropertyName("kick_off")]
        public string KickOff { get; set; }

        public int CompetitionId { get; set; }

        [JsonPropertyName("competition")]
        public Competition Competition { get; set; }

        public int SeasonId { get; set; }

        [JsonPropertyName("season")]
        public Season Season { get; set; }

        public int HomeTeamId { get; set; }

        [JsonPropertyName("home_team")]
        public HomeTeam HomeTeam { get; set; }

        public int AwayTeamId { get; set; }

        [JsonPropertyName("away_team")]
        public AwayTeam AwayTeam { get; set; }

        [JsonPropertyName("home_score")]
        public int HomeScore { get; set; }

        [JsonPropertyName("away_score")]
        public int AwayScore { get; set; }

        [JsonPropertyName("attendance")]
        public int? Attendance { get; set; }

        [JsonPropertyName("behind_closed_doors")]
        public bool BehindClosedDoors { get; set; }

        [JsonPropertyName("neutral_ground")]
        public bool NeutralGround { get; set; }

        [JsonPropertyName("play_status")]
        public string PlayStatus { get; set; }

        [JsonPropertyName("match_status")]
        public string MatchStatus { get; set; }

        [JsonPropertyName("match_status_360")]
        public string MatchStatus360 { get; set; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("last_updated_360")]
        public string LastUpdated360 { get; set; }

        public int CompetitionStageId { get; set; }

        [JsonPropertyName("competition_stage")]
        public CompetitionStage CompetitionStage { get; set; }

        public int StadiumId { get; set; }

        [JsonPropertyName("stadium")]
        public Stadium Stadium { get; set; }

        public int RefereeId { get; set; }

        [JsonPropertyName("referee")]
        public Referee Referee { get; set; }
        [JsonPropertyName("match_week")]
        public int MatchWeek { get; set; }
    }
}