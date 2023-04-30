import { gql } from '@apollo/client';

export const MATCH_PLAYER_STATS_QUERY = gql`
  query MatchPlayerStatsByMatchId($matchId: ID!) {
    matchPlayerStats(matchId: $matchId) {
      id
      matchId
      teamId
      teamName
      playerId
      playerName
      playerMatchMinutes
      playerMatchNpXgPerShot
      playerMatchNpXg
      playerMatchNpShots
      playerMatchGoals
      playerMatchNpGoals
      playerMatchXa
      playerMatchKeyPasses
      playerMatchOpKeyPasses
      playerMatchAssists
      playerMatchThroughBalls
      playerMatchPassesIntoBox
      playerMatchOpPassesIntoBox
      playerMatchTouchesInsideBox
      playerMatchTackles
      playerMatchInterceptions
      playerMatchPossession
      playerMatchDribbledPast
      playerMatchDribblesFaced
      playerMatchDribbles
      playerMatchChallengeRatio
      playerMatchFouls
      playerMatchDispossessions
      playerMatchLongBalls
      playerMatchSuccessfulLongBalls
      playerMatchLongBallRatio
      playerMatchShotsBlocked
      playerMatchClearances
      playerMatchAerials
      playerMatchSuccessfulAerials
      playerMatchAerialRatio
      playerMatchPasses
      playerMatchSuccessfulPasses
      playerMatchPassingRatio
      playerMatchOpPasses
      playerMatchForwardPasses
      playerMatchBackwardPasses
      playerMatchSidewaysPasses
      playerMatchPenaltiesConceded
      playerMatchPenaltiesWon
      playerMatchOpF3Passes
      playerMatchOpF3ForwardPasses
      playerMatchOpF3BackwardPasses
      playerMatchOpF3SidewaysPasses
      playerMatchNpShotsOnTarget
      playerMatchCrosses
      playerMatchSuccessfulCrosses
      playerMatchCrossingRatio
      playerMatchPassesInsideBox
      playerMatchOpXa
      playerMatchOpAssists
      playerMatchPressuredLongBalls
      playerMatchUnpressuredLongBalls
      playerMatchAggressiveActions
      playerMatchTurnovers
      playerMatchCrossesIntoBox
      playerMatchSpXa
      playerMatchOpShots
      playerMatchTouches
      playerMatchPressureRegains
      playerMatchBoxCrossRatio
      playerMatchDeepProgressions
      playerMatchShotTouchRatio
      playerMatchFoulsWon
      playerMatchXgchain
      playerMatchOpXgchain
      playerMatchXgbuildup
      playerMatchOpXgbuildup
      playerMatchXgchainPerPossession
      playerMatchOpXgchainPerPossession
      playerMatchXgbuildupPerPossession
      playerMatchOpXgbuildupPerPossession
      playerMatchPressures
      playerMatchPressureDurationTotal
      playerMatchPressureDurationAvg
      playerMatchPressuredActionFails
      playerMatchCounterpressures
      playerMatchCounterpressureDurationTotal
      playerMatchCounterpressureDurationAvg
      playerMatchCounterpressuredActionFails
      playerMatchObv
      playerMatchObvPass
      playerMatchFhalfPasses360
      playerMatchFhalfObvPasses360
      playerMatchF3Passes360
      playerMatchF3ObvPasses360
      playerMatchBallReceipts360
      playerMatchFhalfBallReceipts360
      playerMatchF3BallReceipts360
      playerMatch360Minutes
      playerMatchObvShot
      playerMatchObvDefensiveAction
      playerMatchObvDribbleCarry
      playerMatchObvGk
      playerMatchDeepCompletions
      playerMatchBallRecoveries
      playerMatchNpPsxg
      playerMatchPenaltiesFaced
      playerMatchFhalfBallRecoveries
      playerMatchAverageSpaceReceivedIn
      playerMatchAverageFhalfSpaceReceivedIn
      playerMatchAverageF3SpaceReceivedIn
      playerMatchBallReceiptsInSpace10
      playerMatchBallReceiptsInSpace2
      playerMatchBallReceiptsInSpace5
      playerMatchFhalfBallReceiptsInSpace10
      playerMatchFhalfBallReceiptsInSpace2
      playerMatchFhalfBallReceiptsInSpace5
      playerMatchF3BallReceiptsInSpace10
      playerMatchF3BallReceiptsInSpace2
      playerMatchF3BallReceiptsInSpace5
      playerMatchLbp
      playerMatchLbpCompleted
      playerMatchFhalfLbpCompleted
      playerMatchF3LbpCompleted
      playerMatchFhalfLbp
      playerMatchF3Lbp
      playerMatchObvLbp
      playerMatchFhalfObvLbp
      playerMatchF3ObvLbp
      playerMatchLbpReceived
      playerMatchFhalfLbpReceived
      playerMatchF3LbpReceived
      playerMatchAverageLbpToSpaceDistance
      playerMatchFhalfAverageLbpToSpaceDistance
      playerMatchF3AverageLbpToSpaceDistance
      playerMatchLbpToSpace10Received
      playerMatchFhalfLbpToSpace10Received
      playerMatchF3LbpToSpace10Received
      playerMatchLbpToSpace2Received
      playerMatchFhalfLbpToSpace2Received
      playerMatchF3LbpToSpace2Received
      playerMatchLbpToSpace5Received
      playerMatchFhalfLbpToSpace5Received
      playerMatchF3LbpToSpace5Received
      playerMatchAverageLbpToSpaceReceivedDistance
      playerMatchFhalfAverageLbpToSpaceReceivedDistance
      playerMatchF3AverageLbpToSpaceReceivedDistance
      playerMatchLbpToSpace10
      playerMatchFhalfLbpToSpace10
      playerMatchF3LbpToSpace10
      playerMatchLbpToSpace2
      playerMatchFhalfLbpToSpace2
      playerMatchF3LbpToSpace2
      playerMatchLbpToSpace5
      playerMatchFhalfLbpToSpace5
      playerMatchF3LbpToSpace5
      playerMatchPasses360
      playerMatchObvPasses360
    }
  }
`;
