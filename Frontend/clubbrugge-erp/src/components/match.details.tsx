// MatchDetails.tsx
import React from 'react';
import { useParams } from 'react-router-dom';
import { useQuery } from '@apollo/client';
import { MATCH_PLAYER_STATS_QUERY } from '../matchPlayerStatsQuery.tsx';
import styles from './match.details.css';

const MatchDetails: React.FC = () => {
    const { matchId } = useParams<{ matchId: string }>();
    const { loading, error, data } = useQuery(MATCH_PLAYER_STATS_QUERY, {
      variables: { matchId },
    });
  
    if (loading) return <p className={styles.loading}>Loading...</p>;
    if (error) return <p className={styles.error}>Error :(</p>;
  
    const copiedData = [...data.matchPlayerStats];
    const sortedStats = copiedData.sort((a, b) => a.teamId - b.teamId);
    const homeTeam = sortedStats.filter((stat) => stat.teamId === sortedStats[0].teamId);
    const awayTeam = sortedStats.filter((stat) => stat.teamId !== sortedStats[0].teamId);
  
    const renderPlayerStats = (playerStats) =>
    playerStats.map((stat) => (
      <div key={stat.id} className="player-stats">
        <h3>{stat.playerName}</h3>
        {Object.entries(stat).map(([key, value]) => {
            if (key !== '__typename' && value !== null && value !== 0) {
                return (
              <div key={key} className="stats">
                {key}: {value}
              </div>
            );
          }
          return null;
        })}
      </div>
    ));

  return (
    <div className="match-details">
      <div className="homeTeam">
        <h2>Home Team</h2>
        {renderPlayerStats(homeTeam)}
      </div>
      <div className="awayTeam">
        <h2>Away Team</h2>
        {renderPlayerStats(awayTeam)}
      </div>
    </div>
  );
};
  
  
  export default MatchDetails;