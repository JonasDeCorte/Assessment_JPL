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
    }
  }
`;
