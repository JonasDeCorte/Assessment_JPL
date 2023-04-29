using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class MatchPlayerStatsType : ObjectType<MatchPlayerStats>
    {
        protected override void Configure(IObjectTypeDescriptor<MatchPlayerStats> descriptor)
        {
            descriptor.Field(p => p.Id).Type<IdType>();
            descriptor.Field(p => p.MatchId).Type<IdType>();
            descriptor.Field(p => p.TeamId).Type<IdType>();
            descriptor.Field(p => p.TeamName).Type<StringType>();
            descriptor.Field(p => p.PlayerId).Type<IdType>();
            descriptor.Field(p => p.PlayerName).Type<StringType>();
            descriptor.Field(p => p.PlayerMatchMinutes).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchNpXgPerShot).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchNpXg).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchNpShots).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchGoals).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchNpGoals).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchXa).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchKeyPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpKeyPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchAssists).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchThroughBalls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPassesIntoBox).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpPassesIntoBox).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchTouchesInsideBox).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchTackles).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchInterceptions).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPossession).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchDribbledPast).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchDribblesFaced).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchDribbles).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchChallengeRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchFouls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchDispossessions).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchLongBalls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSuccessfulLongBalls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchLongBallRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchShotsBlocked).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchClearances).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchAerials).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSuccessfulAerials).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchAerialRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSuccessfulPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPassingRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchForwardPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchBackwardPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSidewaysPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPenaltiesConceded).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPenaltiesWon).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpF3Passes).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpF3ForwardPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpF3BackwardPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpF3SidewaysPasses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchNpShotsOnTarget).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchCrosses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSuccessfulCrosses).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchCrossingRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchPenaltiesWon).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPassesInsideBox).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchOpXa).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpAssists).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPressuredLongBalls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchUnpressuredLongBalls).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchAggressiveActions).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchTurnovers).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchCrossesIntoBox).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchSpXa).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpShots).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchTouches).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPressureRegains).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchBoxCrossRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchDeepProgressions).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchShotTouchRatio).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchFoulsWon).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchXgchain).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpXgchain).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchXgbuildup).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpXgbuildup).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchXgchainPerPossession).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpXgchainPerPossession).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchXgbuildupPerPossession).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchOpXgbuildupPerPossession).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchPressures).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchPressureDurationTotal).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchPressureDurationAvg).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchPressuredActionFails).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchCounterpressures).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchCounterpressureDurationTotal).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchCounterpressureDurationAvg).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchCounterpressuredActionFails).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchObv).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchObvPass).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchFhalfPasses360).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchFhalfObvPasses360).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchF3Passes360).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchF3ObvPasses360).Type<FloatType>();
            descriptor.Field(p => p.PlayerMatchBallReceipts360).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchFhalfBallReceipts360).Type<IntType>();
            descriptor.Field(p => p.PlayerMatchF3BallReceipts360).Type<IntType>();
            descriptor.Field(p => p.PlayerMatch360Minutes).Type<FloatType>();
        }
    }
}