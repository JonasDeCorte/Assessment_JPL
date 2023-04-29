import { gql } from '@apollo/client';

export const MATCHES_QUERY = gql`
query{
  matches{
    matchId
    matchDate
    kickOff
    competition {
      competitionId
      countryName
      name
    }
    season {
      seasonId
      name
    }
  homeTeam {
  homeTeamId
  homeTeamName
  country{
    countryId
    name
  }
  homeTeamManagers{
    managerId
    name
    dateOfBirth
    country {
      countryId
      name
    }
  }
  }
  awayTeam {
    awayTeamId
    awayTeamName
    country {
      countryId
      name
    }
    awayTeamManagers{
      managerId
      name
      nickname
      dateOfBirth
      country {
        name
        countryId
      }
    }
  }
  homeScore
  awayScore
  neutralGround
  matchWeek
  competitionStage {
    name
  }
  stadium {
    name
    country {
      name
    }
  }
  referee {
    name
    country {
      name
    }
  }
  matchDate
  }
}
`;
