import React from 'react';
import { useQuery } from '@apollo/client';
import { MATCHES_QUERY } from '../matchesQuery.tsx';
import './matches.overview.css';
import { Link } from 'react-router-dom';

const Matches: React.FC = () => {
  const { loading, error, data } = useQuery(MATCHES_QUERY);

  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: {error.message}</p>;

  return (
    <div className="matches">
      <div className="matches__header">
        <h1>Matches</h1>
      </div>
      <div className="grid-wrapper">
        {data.matches.map((match: any) => (
          <Link to={`/match/${match.matchId}`}>
          <div key={match.matchId} className="matches__match">
            <div className="matches__teams">
              <h2 className="matches__team">{match.homeTeam.homeTeamName}</h2>
              <h2 className="matches__team">{match.homeScore}</h2>
              - 
              <h2 className="matches__team">{match.awayScore}</h2>
              <h2 className="matches__team">{match.awayTeam.awayTeamName}</h2>
            </div>
            <div className="matches__info">
              <p className="matches__date">{match.matchDate}</p>
              <p className="matches__kickoff">{match.kickOff}</p>
              <p className="matches__competition">{match.competition.name} ({match.competition.countryName})</p>
              <p className="matches__season">{match.season.name}</p>
              <p className="matches__week">{match.matchWeek}</p>
              <p className="matches__stage">{match.competitionStage.name}</p>
              <p className="matches__stadium">{match.stadium.name} ({match.stadium.country.name})</p>
              <p className="matches__referee">{match.referee.name} ({match.referee.country.name})</p>
            </div>
          </div>
          </Link>
        ))}
      </div>
    </div>
  );
  
};

export default Matches;
