import React from 'react';
import { useParams } from 'react-router-dom';
import { useQuery } from '@apollo/client';
import { MATCH_PLAYER_STATS_QUERY } from '../matchPlayerStatsQuery.tsx';
import './match.details.css';
// MatchDetails.tsx
const MatchDetails: React.FC = () => {
    const { matchId } = useParams<{ matchId: string }>();
    const { loading, error, data } = useQuery(MATCH_PLAYER_STATS_QUERY, {
      variables: { matchId },
    });
  
    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error: {error.message}</p>;
  
    return (
        <div className="match-details">
          {data.matchPlayerStats.map((player: any) => (
            <div key={player.id} className="player-stats">
              <h3>{player.playerName} ({player.teamName})</h3>
              <p>Minutes: {player.playerMatchMinutes}</p>
              <p>Non-penalty xG per shot: {player.playerMatchNpXgPerShot}</p>
              <p>Non-penalty xG: {player.playerMatchNpXg}</p>
              <p>Non-penalty shots: {player.playerMatchNpShots}</p>
              <p>Goals: {player.playerMatchGoals}</p>
              <p>Non-penalty goals: {player.playerMatchNpGoals}</p>
              <p>xA: {player.playerMatchXa}</p>
              <p>Key passes: {player.playerMatchKeyPasses}</p>
              <p>Opportunity-creating key passes: {player.playerMatchOpKeyPasses}</p>
              <p>Assists: {player.playerMatchAssists}</p>
              <p>Through balls: {player.playerMatchThroughBalls}</p>
              <p>Passes into box: {player.playerMatchPassesIntoBox}</p>
              <p>Opportunity-creating passes into box: {player.playerMatchOpPassesIntoBox}</p>
              <p>Touches inside box: {player.playerMatchTouchesInsideBox}</p>
              <p>Tackles: {player.playerMatchTackles}</p>
              <p>Interceptions: {player.playerMatchInterceptions}</p>
              <p>Possession: {player.playerMatchPossession}</p>
              <p>Dribbled past: {player.playerMatchDribbledPast}</p>
              <p>Dribbles faced: {player.playerMatchDribblesFaced}</p>
            </div>
          ))}
        </div>
      );
    };
  
  export default MatchDetails;
  