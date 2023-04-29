using System.Text.Json.Serialization;

namespace ClubBrugge.Erp.Domain.Entities
{
    public class MatchPlayerStats
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonPropertyName("match_id")]
        public int? MatchId { get; set; }

        [JsonPropertyName("team_id")]
        public int? TeamId { get; set; }

        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        [JsonPropertyName("player_id")]
        public int? PlayerId { get; set; }

        [JsonPropertyName("player_name")]
        public string PlayerName { get; set; }

        [JsonPropertyName("player_match_minutes")]
        public double? PlayerMatchMinutes { get; set; }

        [JsonPropertyName("player_match_np_xg_per_shot")]
        public double? PlayerMatchNpXgPerShot { get; set; }

        [JsonPropertyName("player_match_np_xg")]
        public double? PlayerMatchNpXg { get; set; }

        [JsonPropertyName("player_match_np_shots")]
        public int? PlayerMatchNpShots { get; set; }

        [JsonPropertyName("player_match_goals")]
        public int? PlayerMatchGoals { get; set; }

        [JsonPropertyName("player_match_np_goals")]
        public int? PlayerMatchNpGoals { get; set; }

        [JsonPropertyName("player_match_xa")]
        public double? PlayerMatchXa { get; set; }

        [JsonPropertyName("player_match_key_passes")]
        public int? PlayerMatchKeyPasses { get; set; }

        [JsonPropertyName("player_match_op_key_passes")]
        public int? PlayerMatchOpKeyPasses { get; set; }

        [JsonPropertyName("player_match_assists")]
        public int? PlayerMatchAssists { get; set; }

        [JsonPropertyName("player_match_through_balls")]
        public int? PlayerMatchThroughBalls { get; set; }

        [JsonPropertyName("player_match_passes_into_box")]
        public int? PlayerMatchPassesIntoBox { get; set; }

        [JsonPropertyName("player_match_op_passes_into_box")]
        public int? PlayerMatchOpPassesIntoBox { get; set; }

        [JsonPropertyName("player_match_touches_inside_box")]
        public int? PlayerMatchTouchesInsideBox { get; set; }

        [JsonPropertyName("player_match_tackles")]
        public int? PlayerMatchTackles { get; set; }

        [JsonPropertyName("player_match_interceptions")]
        public int? PlayerMatchInterceptions { get; set; }

        [JsonPropertyName("player_match_possession")]
        public double? PlayerMatchPossession { get; set; }

        [JsonPropertyName("player_match_dribbled_past")]
        public int? PlayerMatchDribbledPast { get; set; }

        [JsonPropertyName("player_match_dribbles_faced")]
        public int? PlayerMatchDribblesFaced { get; set; }

        [JsonPropertyName("player_match_dribbles")]
        public int? PlayerMatchDribbles { get; set; }

        [JsonPropertyName("player_match_challenge_ratio")]
        public double? PlayerMatchChallengeRatio { get; set; }

        [JsonPropertyName("player_match_fouls")]
        public int? PlayerMatchFouls { get; set; }

        [JsonPropertyName("player_match_dispossessions")]
        public int? PlayerMatchDispossessions { get; set; }

        [JsonPropertyName("player_match_long_balls")]
        public int? PlayerMatchLongBalls { get; set; }

        [JsonPropertyName("player_match_successful_long_balls")]
        public int? PlayerMatchSuccessfulLongBalls { get; set; }

        [JsonPropertyName("player_match_long_ball_ratio")]
        public double? PlayerMatchLongBallRatio { get; set; }

        [JsonPropertyName("player_match_shots_blocked")]
        public int? PlayerMatchShotsBlocked { get; set; }

        [JsonPropertyName("player_match_clearances")]
        public int? PlayerMatchClearances { get; set; }

        [JsonPropertyName("player_match_aerials")]
        public int? PlayerMatchAerials { get; set; }

        [JsonPropertyName("player_match_successful_aerials")]
        public int? PlayerMatchSuccessfulAerials { get; set; }

        [JsonPropertyName("player_match_aerial_ratio")]
        public double? PlayerMatchAerialRatio { get; set; }

        [JsonPropertyName("player_match_passes")]
        public int? PlayerMatchPasses { get; set; }

        [JsonPropertyName("player_match_successful_passes")]
        public int? PlayerMatchSuccessfulPasses { get; set; }

        [JsonPropertyName("player_match_passing_ratio")]
        public double? PlayerMatchPassingRatio { get; set; }

        [JsonPropertyName("player_match_op_passes")]
        public int? PlayerMatchOpPasses { get; set; }

        [JsonPropertyName("player_match_forward_passes")]
        public int? PlayerMatchForwardPasses { get; set; }

        [JsonPropertyName("player_match_backward_passes")]
        public int? PlayerMatchBackwardPasses { get; set; }

        [JsonPropertyName("player_match_sideways_passes")]
        public int? PlayerMatchSidewaysPasses { get; set; }

        [JsonPropertyName("player_match_op_f3_passes")]
        public int? PlayerMatchOpF3Passes { get; set; }

        [JsonPropertyName("player_match_op_f3_forward_passes")]
        public int? PlayerMatchOpF3ForwardPasses { get; set; }

        [JsonPropertyName("player_match_op_f3_backward_passes")]
        public int? PlayerMatchOpF3BackwardPasses { get; set; }

        [JsonPropertyName("player_match_op_f3_sideways_passes")]
        public int? PlayerMatchOpF3SidewaysPasses { get; set; }

        [JsonPropertyName("player_match_np_shots_on_target")]
        public int? PlayerMatchNpShotsOnTarget { get; set; }

        [JsonPropertyName("player_match_crosses")]
        public int? PlayerMatchCrosses { get; set; }

        [JsonPropertyName("player_match_successful_crosses")]
        public int? PlayerMatchSuccessfulCrosses { get; set; }

        [JsonPropertyName("player_match_crossing_ratio")]
        public double? PlayerMatchCrossingRatio { get; set; }

        [JsonPropertyName("player_match_penalties_won")]
        public int? PlayerMatchPenaltiesWon { get; set; }

        [JsonPropertyName("player_match_passes_inside_box")]
        public int? PlayerMatchPassesInsideBox { get; set; }

        [JsonPropertyName("player_match_op_xa")]
        public double? PlayerMatchOpXa { get; set; }

        [JsonPropertyName("player_match_op_assists")]
        public int? PlayerMatchOpAssists { get; set; }

        [JsonPropertyName("player_match_pressured_long_balls")]
        public int? PlayerMatchPressuredLongBalls { get; set; }

        [JsonPropertyName("player_match_unpressured_long_balls")]
        public int? PlayerMatchUnpressuredLongBalls { get; set; }

        [JsonPropertyName("player_match_aggressive_actions")]
        public int? PlayerMatchAggressiveActions { get; set; }

        [JsonPropertyName("player_match_turnovers")]
        public int? PlayerMatchTurnovers { get; set; }

        [JsonPropertyName("player_match_crosses_into_box")]
        public int? PlayerMatchCrossesIntoBox { get; set; }

        [JsonPropertyName("player_match_sp_xa")]
        public double? PlayerMatchSpXa { get; set; }

        [JsonPropertyName("player_match_op_shots")]
        public int? PlayerMatchOpShots { get; set; }

        [JsonPropertyName("player_match_touches")]
        public int? PlayerMatchTouches { get; set; }

        [JsonPropertyName("player_match_pressure_regains")]
        public int? PlayerMatchPressureRegains { get; set; }

        [JsonPropertyName("player_match_box_cross_ratio")]
        public double? PlayerMatchBoxCrossRatio { get; set; }

        [JsonPropertyName("player_match_deep_progressions")]
        public int? PlayerMatchDeepProgressions { get; set; }

        [JsonPropertyName("player_match_shot_touch_ratio")]
        public double? PlayerMatchShotTouchRatio { get; set; }

        [JsonPropertyName("player_match_fouls_won")]
        public int? PlayerMatchFoulsWon { get; set; }

        [JsonPropertyName("player_match_xgchain")]
        public double? PlayerMatchXgchain { get; set; }

        [JsonPropertyName("player_match_op_xgchain")]
        public double? PlayerMatchOpXgchain { get; set; }

        [JsonPropertyName("player_match_xgbuildup")]
        public double? PlayerMatchXgbuildup { get; set; }

        [JsonPropertyName("player_match_op_xgbuildup")]
        public double? PlayerMatchOpXgbuildup { get; set; }

        [JsonPropertyName("player_match_xgchain_per_possession")]
        public double? PlayerMatchXgchainPerPossession { get; set; }

        [JsonPropertyName("player_match_op_xgchain_per_possession")]
        public double? PlayerMatchOpXgchainPerPossession { get; set; }

        [JsonPropertyName("player_match_xgbuildup_per_possession")]
        public double? PlayerMatchXgbuildupPerPossession { get; set; }

        [JsonPropertyName("player_match_op_xgbuildup_per_possession")]
        public double? PlayerMatchOpXgbuildupPerPossession { get; set; }

        [JsonPropertyName("player_match_pressures")]
        public int? PlayerMatchPressures { get; set; }

        [JsonPropertyName("player_match_pressure_duration_total")]
        public double? PlayerMatchPressureDurationTotal { get; set; }

        [JsonPropertyName("player_match_pressure_duration_avg")]
        public double? PlayerMatchPressureDurationAvg { get; set; }

        [JsonPropertyName("player_match_pressured_action_fails")]
        public int? PlayerMatchPressuredActionFails { get; set; }

        [JsonPropertyName("player_match_counterpressures")]
        public int? PlayerMatchCounterpressures { get; set; }

        [JsonPropertyName("player_match_counterpressure_duration_total")]
        public double? PlayerMatchCounterpressureDurationTotal { get; set; }

        [JsonPropertyName("player_match_counterpressure_duration_avg")]
        public double? PlayerMatchCounterpressureDurationAvg { get; set; }

        [JsonPropertyName("player_match_counterpressured_action_fails")]
        public int? PlayerMatchCounterpressuredActionFails { get; set; }

        [JsonPropertyName("player_match_obv")]
        public double? PlayerMatchObv { get; set; }

        [JsonPropertyName("player_match_obv_pass")]
        public double? PlayerMatchObvPass { get; set; }

        [JsonPropertyName("player_match_obv_shot")]
        public double? PlayerMatchObvShot { get; set; }

        [JsonPropertyName("player_match_obv_defensive_action")]
        public double? PlayerMatchObvDefensiveAction { get; set; }

        [JsonPropertyName("player_match_obv_dribble_carry")]
        public double? PlayerMatchObvDribbleCarry { get; set; }

        [JsonPropertyName("player_match_obv_gk")]
        public double? PlayerMatchObvGk { get; set; }

        [JsonPropertyName("player_match_deep_completions")]
        public int? PlayerMatchDeepCompletions { get; set; }

        [JsonPropertyName("player_match_ball_recoveries")]
        public int? PlayerMatchBallRecoveries { get; set; }

        [JsonPropertyName("player_match_np_psxg")]
        public double? PlayerMatchNpPsxg { get; set; }

        [JsonPropertyName("player_match_penalties_faced")]
        public int? PlayerMatchPenaltiesFaced { get; set; }

        [JsonPropertyName("player_match_penalties_conceded")]
        public int? PlayerMatchPenaltiesConceded { get; set; }

        [JsonPropertyName("player_match_fhalf_ball_recoveries")]
        public int? PlayerMatchFhalfBallRecoveries { get; set; }

        [JsonPropertyName("player_match_average_space_received_in")]
        public double? PlayerMatchAverageSpaceReceivedIn { get; set; }

        [JsonPropertyName("player_match_average_fhalf_space_received_in")]
        public double? PlayerMatchAverageFhalfSpaceReceivedIn { get; set; }

        [JsonPropertyName("player_match_average_f3_space_received_in")]
        public double? PlayerMatchAverageF3SpaceReceivedIn { get; set; }

        [JsonPropertyName("player_match_ball_receipts_in_space_10")]
        public int? PlayerMatchBallReceiptsInSpace10 { get; set; }

        [JsonPropertyName("player_match_ball_receipts_in_space_2")]
        public int? PlayerMatchBallReceiptsInSpace2 { get; set; }

        [JsonPropertyName("player_match_ball_receipts_in_space_5")]
        public int? PlayerMatchBallReceiptsInSpace5 { get; set; }

        [JsonPropertyName("player_match_fhalf_ball_receipts_in_space_10")]
        public int? PlayerMatchFhalfBallReceiptsInSpace10 { get; set; }

        [JsonPropertyName("player_match_fhalf_ball_receipts_in_space_2")]
        public int? PlayerMatchFhalfBallReceiptsInSpace2 { get; set; }

        [JsonPropertyName("player_match_fhalf_ball_receipts_in_space_5")]
        public int? PlayerMatchFhalfBallReceiptsInSpace5 { get; set; }

        [JsonPropertyName("player_match_f3_ball_receipts_in_space_10")]
        public int? PlayerMatchF3BallReceiptsInSpace10 { get; set; }

        [JsonPropertyName("player_match_f3_ball_receipts_in_space_2")]
        public int? PlayerMatchF3BallReceiptsInSpace2 { get; set; }

        [JsonPropertyName("player_match_f3_ball_receipts_in_space_5")]
        public int? PlayerMatchF3BallReceiptsInSpace5 { get; set; }

        [JsonPropertyName("player_match_lbp")]
        public double? PlayerMatchLbp { get; set; }

        [JsonPropertyName("player_match_lbp_completed")]
        public int? PlayerMatchLbpCompleted { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_completed")]
        public int? PlayerMatchFhalfLbpCompleted { get; set; }

        [JsonPropertyName("player_match_f3_lbp_completed")]
        public int? PlayerMatchF3LbpCompleted
        {
            get; set;
        }

        [JsonPropertyName("player_match_fhalf_lbp")]
        public int? PlayerMatchFhalfLbp { get; set; }

        [JsonPropertyName("player_match_f3_lbp")]
        public int? PlayerMatchF3Lbp { get; set; }

        [JsonPropertyName("player_match_obv_lbp")]
        public double? PlayerMatchObvLbp { get; set; }

        [JsonPropertyName("player_match_fhalf_obv_lbp")]
        public double? PlayerMatchFhalfObvLbp { get; set; }

        [JsonPropertyName("player_match_f3_obv_lbp")]
        public double? PlayerMatchF3ObvLbp { get; set; }

        [JsonPropertyName("player_match_lbp_received")]
        public int? PlayerMatchLbpReceived { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_received")]
        public int? PlayerMatchFhalfLbpReceived { get; set; }

        [JsonPropertyName("player_match_f3_lbp_received")]
        public int? PlayerMatchF3LbpReceived { get; set; }

        [JsonPropertyName("player_match_average_lbp_to_space_distance")]
        public double? PlayerMatchAverageLbpToSpaceDistance { get; set; }

        [JsonPropertyName("player_match_fhalf_average_lbp_to_space_distance")]
        public double? PlayerMatchFhalfAverageLbpToSpaceDistance { get; set; }

        [JsonPropertyName("player_match_f3_average_lbp_to_space_distance")]
        public double? PlayerMatchF3AverageLbpToSpaceDistance { get; set; }

        [JsonPropertyName("player_match_lbp_to_space_10_received")]
        public int? PlayerMatchLbpToSpace10Received { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_10_received")]
        public int? PlayerMatchFhalfLbpToSpace10Received { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_10_received")]
        public int? PlayerMatchF3LbpToSpace10Received { get; set; }

        [JsonPropertyName("player_match_lbp_to_space_2_received")]
        public int? PlayerMatchLbpToSpace2Received { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_2_received")]
        public int? PlayerMatchFhalfLbpToSpace2Received { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_2_received")]
        public int? PlayerMatchF3LbpToSpace2Received { get; set; }

        [JsonPropertyName("player_match_lbp_to_space_5_received")]
        public int? PlayerMatchLbpToSpace5Received { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_5_received")]
        public int? PlayerMatchFhalfLbpToSpace5Received { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_5_received")]
        public int? PlayerMatchF3LbpToSpace5Received { get; set; }

        [JsonPropertyName("player_match_average_lbp_to_space_received_distance")]
        public double? PlayerMatchAverageLbpToSpaceReceivedDistance { get; set; }

        [JsonPropertyName("player_match_fhalf_average_lbp_to_space_received_distance")]
        public double? PlayerMatchFhalfAverageLbpToSpaceReceivedDistance { get; set; }

        [JsonPropertyName("player_match_f3_average_lbp_to_space_received_distance")]
        public double? PlayerMatchF3AverageLbpToSpaceReceivedDistance
        {
            get; set;
        }

        [JsonPropertyName("player_match_lbp_to_space_10")]
        public int? PlayerMatchLbpToSpace10 { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_10")]
        public int? PlayerMatchFhalfLbpToSpace10 { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_10")]
        public int? PlayerMatchF3LbpToSpace10 { get; set; }

        [JsonPropertyName("player_match_lbp_to_space_2")]
        public int? PlayerMatchLbpToSpace2 { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_2")]
        public int? PlayerMatchFhalfLbpToSpace2 { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_2")]
        public int? PlayerMatchF3LbpToSpace2 { get; set; }

        [JsonPropertyName("player_match_lbp_to_space_5")]
        public int? PlayerMatchLbpToSpace5 { get; set; }

        [JsonPropertyName("player_match_fhalf_lbp_to_space_5")]
        public int? PlayerMatchFhalfLbpToSpace5 { get; set; }

        [JsonPropertyName("player_match_f3_lbp_to_space_5")]
        public int? PlayerMatchF3LbpToSpace5 { get; set; }

        [JsonPropertyName("player_match_passes_360")]
        public int? PlayerMatchPasses360 { get; set; }

        [JsonPropertyName("player_match_obv_passes_360")]
        public double? PlayerMatchObvPasses360 { get; set; }

        [JsonPropertyName("player_match_fhalf_passes_360")]
        public int? PlayerMatchFhalfPasses360 { get; set; }

        [JsonPropertyName("player_match_fhalf_obv_passes_360")]
        public double? PlayerMatchFhalfObvPasses360 { get; set; }

        [JsonPropertyName("player_match_f3_passes_360")]
        public int? PlayerMatchF3Passes360 { get; set; }

        [JsonPropertyName("player_match_f3_obv_passes_360")]
        public double? PlayerMatchF3ObvPasses360 { get; set; }

        [JsonPropertyName("player_match_ball_receipts_360")]
        public int? PlayerMatchBallReceipts360 { get; set; }

        [JsonPropertyName("player_match_fhalf_ball_receipts_360")]
        public int? PlayerMatchFhalfBallReceipts360 { get; set; }

        [JsonPropertyName("player_match_f3_ball_receipts_360")]
        public int? PlayerMatchF3BallReceipts360 { get; set; }

        [JsonPropertyName("player_match_360_minutes")]
        public double? PlayerMatch360Minutes { get; set; }
    }
}