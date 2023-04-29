using ClubBrugge.Erp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text.Json;

namespace ClubBrugge.Erp.Application.DataSeed
{
    public class DataSeeder
    {
        public static async Task LoadMatchDataAsync(ApplicationDbContext dbContext)
        {
            var basePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..", "ClubBrugge.Erp.Application", "DataSeed", "matches");
            var matchesDirectories = Directory.GetDirectories(basePath);

            foreach (var matchDirectory in matchesDirectories)
            {
                var infoJsonFile = System.IO.Path.Combine(matchDirectory, "info.json");

                if (!File.Exists(infoJsonFile))
                {
                    continue;
                }

                var matchJson = await File.ReadAllTextAsync(infoJsonFile);
                var match = JsonSerializer.Deserialize<Match>(matchJson);

                var existingMatch = await dbContext.Matches.FindAsync(match.MatchId);

                if (existingMatch != null)
                {
                    continue;
                }

                var existingCountry = await AddOrUpdateCountry(dbContext, match.HomeTeam.Country.Name, match.HomeTeam.Country.CountryId);
                await AddOrUpdateCompetition(dbContext, match);
                await AddOrUpdateCompetitionStage(dbContext, match);
                await AddOrUpdateSeason(dbContext, match);
                await AddOrUpdateStadium(dbContext, match, existingCountry);
                await AddOrUpdateReferee(dbContext, match, existingCountry);
                await AddOrUpdateHomeTeam(dbContext, match, existingCountry);
                await AddOrUpdateAwayTeam(dbContext, match, existingCountry);

                await dbContext.Matches.AddAsync(match);
                await dbContext.SaveChangesAsync();
            }
        }

        public static async Task LoadMatchPlayerStatsDataAsync(ApplicationDbContext dbContext)
        {
            var basePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..", "ClubBrugge.Erp.Application", "DataSeed", "matches");
            var matchesDirectories = Directory.GetDirectories(basePath);

            foreach (var matchDirectory in matchesDirectories)
            {
                var infoJsonFile = System.IO.Path.Combine(matchDirectory, "stats.json");

                if (!File.Exists(infoJsonFile))
                {
                    continue;
                }

                var matchPlayerJson = await File.ReadAllTextAsync(infoJsonFile);
                var matchPlayers = JsonSerializer.Deserialize<MatchPlayerStats[]>(matchPlayerJson);

                foreach (var item in matchPlayers)
                {
                    var existingmatchPlayer = await dbContext.MatchPlayerStats.FindAsync(item.Id);
                    if (existingmatchPlayer != null)
                    {
                        continue;
                    }

                    await dbContext.MatchPlayerStats.AddAsync(item);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task<Country> AddOrUpdateCountry(ApplicationDbContext dbContext, string countryName, int countryId)
        {
            var existingCountry = await dbContext.Countries
                .Where(x => x.CountryId.Equals(countryId))
                .FirstOrDefaultAsync();

            if (existingCountry == null)
            {
                existingCountry = new Country { CountryId = countryId, Name = countryName };
                await dbContext.Countries.AddAsync(existingCountry);
                await dbContext.SaveChangesAsync();
            }

            return existingCountry;
        }

        private static async Task AddOrUpdateCompetition(ApplicationDbContext dbContext, Match match)
        {
            var competition = new Competition
            {
                CompetitionId = match.Competition.CompetitionId,
                Name = match.Competition.Name,
                CountryName = match.Competition.CountryName,
            };
            var existingCompetition = await AddOrUpdateEntity(dbContext, competition, x => x.CompetitionId.Equals(competition.CompetitionId));
            match.CompetitionId = existingCompetition.Id;
        }

        private static async Task AddOrUpdateCompetitionStage(ApplicationDbContext dbContext, Match match)
        {
            var competitionStage = new CompetitionStage
            {
                CompetitionStageId = match.CompetitionStage.CompetitionStageId,
                Name = match.CompetitionStage.Name,
            };
            var existingCompetitionStage = await AddOrUpdateEntity(dbContext, competitionStage, x => x.CompetitionStageId.Equals(competitionStage.CompetitionStageId));
            match.CompetitionStageId = existingCompetitionStage.Id;
            match.CompetitionStage = existingCompetitionStage;
        }

        private static async Task AddOrUpdateSeason(ApplicationDbContext dbContext, Match match)
        {
            var season = new Season
            {
                SeasonId = match.Season.SeasonId,
                Name = match.Season.Name,
            };
            var existingSeason = await AddOrUpdateEntity(dbContext, season, x => x.SeasonId.Equals(season.SeasonId));
            match.SeasonId = existingSeason.Id;
        }

        private static async Task AddOrUpdateStadium(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var stadium = new Stadium
            {
                StadiumId = match.Stadium.StadiumId,
                Name = match.Stadium.Name,
            };
            var existingStadium = await dbContext.Stadiums
                .Where(x => x.StadiumId.Equals(stadium.StadiumId))
                .FirstOrDefaultAsync();

            int stadiumCountryId = match.Stadium.Country.CountryId;
            string stadiumCountryName = match.Stadium.Country.Name;
            var existingStadiumCountry = await dbContext.Countries
              .Where(x => x.CountryId.Equals(stadiumCountryId))
              .FirstOrDefaultAsync();
            if (existingStadiumCountry == null)
            {
                var newCountry = new Country { CountryId = stadiumCountryId, Name = stadiumCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                stadium.CountryId = newCountry.Id;
            }
            else
            {
                stadium.CountryId = existingCountry.Id;
            }
            await dbContext.SaveChangesAsync();

            if (existingStadium == null)
            {
                await dbContext.Stadiums.AddAsync(stadium);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                match.StadiumId = existingStadium.Id;
            }
        }

        private static async Task AddOrUpdateReferee(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var referee = new Referee
            {
                RefereeId = match.Referee.RefereeId,
                Name = match.Referee.Name,
            };

            int refereeCountryId = match.Referee.Country.CountryId;
            string refereeCountryName = match.Referee.Country.Name;
            var existingRefereeCountry = await dbContext.Countries
              .Where(x => x.CountryId.Equals(refereeCountryId))
              .FirstOrDefaultAsync();
            if (existingRefereeCountry == null)
            {
                var newCountry = new Country { CountryId = refereeCountryId, Name = refereeCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                referee.CountryId = newCountry.Id;
            }
            else
            {
                referee.CountryId = existingCountry.Id;
            }
            await dbContext.SaveChangesAsync();

            var existingReferee = await dbContext.Referees
                .Where(x => x.Name.Equals(referee.Name))
                .FirstOrDefaultAsync();
            if (existingReferee == null)
            {
                await dbContext.Referees.AddAsync(referee);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                match.RefereeId = existingReferee.RefereeId;
            }
        }

        private static async Task AddOrUpdateHomeTeam(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var homeTeam = new HomeTeam
            {
                HomeTeamId = match.HomeTeam.HomeTeamId,
                HomeTeamName = match.HomeTeam.HomeTeamName,
                HomeTeamGender = match.HomeTeam.HomeTeamGender,
                HomeTeamYouth = match.HomeTeam.HomeTeamYouth,
            };

            int homeTeamCountryId = match.HomeTeam.Country.CountryId;
            string homeTeamCountryName = match.HomeTeam.Country.Name;
            var existingHomeCountry = await dbContext.Countries
              .Where(x => x.CountryId.Equals(homeTeamCountryId))
              .FirstOrDefaultAsync();
            if (existingHomeCountry == null)
            {
                var newCountry = new Country { CountryId = homeTeamCountryId, Name = homeTeamCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                homeTeam.CountryId = newCountry.Id;
            }
            else
            {
                homeTeam.CountryId = existingCountry.Id;
            }

            var existingHomeTeam = await dbContext.HomeTeams
              .Where(x => x.HomeTeamName.Equals(homeTeam.HomeTeamName))
              .FirstOrDefaultAsync();
            if (existingHomeTeam == null)
            {
                await dbContext.HomeTeams.AddAsync(homeTeam);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                match.HomeTeamId = existingHomeTeam.Id;
            }

            foreach (var HTmanager in match.HomeTeam.HomeTeamManagers)
            {
                var manager = new Manager
                {
                    ManagerId = HTmanager.ManagerId,
                    DateOfBirth = HTmanager.DateOfBirth,
                    Name = HTmanager.Name,
                    Nickname = HTmanager.Nickname,
                };

                string htManagerCountryName = HTmanager.Country.Name;
                int htManagerCountryId = HTmanager.Country.CountryId;

                var existinghtManagerCountry = await dbContext.Countries
                  .Where(x => x.CountryId.Equals(htManagerCountryId))
                  .FirstOrDefaultAsync();
                if (existinghtManagerCountry == null)
                {
                    var x = new Country { CountryId = htManagerCountryId, Name = htManagerCountryName };
                    await dbContext.Countries.AddAsync(x);
                    await dbContext.SaveChangesAsync();
                    manager.CountryId = x.Id;
                }
                else
                {
                    manager.CountryId = existingCountry.Id;
                }

                var existingHTmanager = await dbContext.Managers
                  .Where(x => x.Name.Equals(HTmanager.Name))
                  .FirstOrDefaultAsync();

                if (existingHTmanager == null)
                {
                    await dbContext.Managers.AddAsync(manager);
                    homeTeam.HomeTeamManagers.Add(manager);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    homeTeam.HomeTeamManagers.Add(existingHTmanager);
                }
            }
        }

        private static async Task AddOrUpdateAwayTeam(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var awayTeam = new AwayTeam
            {
                AwayTeamId = match.AwayTeam.AwayTeamId,
                AwayTeamName = match.AwayTeam.AwayTeamName,
                AwayTeamGender = match.AwayTeam.AwayTeamGender,
                AwayTeamYouth = match.AwayTeam.AwayTeamYouth,
            };

            string awayTeamCountryName = match.AwayTeam.Country.Name;
            int awayTeamCountryId = match.AwayTeam.Country.CountryId;

            var existingAwayCountry = await dbContext.Countries
              .Where(x => x.CountryId.Equals(awayTeamCountryId))
              .FirstOrDefaultAsync();
            if (existingAwayCountry == null)
            {
                var newCountry = new Country { CountryId = awayTeamCountryId, Name = awayTeamCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                awayTeam.CountryId = newCountry.Id;
            }
            else
            {
                awayTeam.CountryId = existingCountry.Id;
            }
            await dbContext.SaveChangesAsync();

            // Add away team if it doesn't exist
            var existingAwayTeam = await dbContext.AwayTeams
              .Where(x => x.AwayTeamName.Equals(awayTeam.AwayTeamName))
              .FirstOrDefaultAsync();
            if (existingAwayTeam == null)
            {
                await dbContext.AwayTeams.AddAsync(awayTeam);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                match.AwayTeamId = existingAwayTeam.Id;
            }

            foreach (var Awaymanager in match.AwayTeam.AwayTeamManagers)
            {
                var manager = new Manager
                {
                    ManagerId = Awaymanager.ManagerId,
                    DateOfBirth = Awaymanager.DateOfBirth,
                    Name = Awaymanager.Name,
                    Nickname = Awaymanager.Nickname,
                };
                string atManagerCountryName = Awaymanager.Country.Name;
                int atManagerCountryId = Awaymanager.Country.CountryId;

                var existingatManagerCountry = await dbContext.Countries
                  .Where(x => x.CountryId.Equals(atManagerCountryId))
                  .FirstOrDefaultAsync();
                if (existingatManagerCountry == null)
                {
                    var x = new Country { CountryId = atManagerCountryId, Name = atManagerCountryName };
                    await dbContext.Countries.AddAsync(x);
                    await dbContext.SaveChangesAsync();
                    manager.CountryId = x.Id;
                }
                else
                {
                    manager.CountryId = existingCountry.Id;
                }
                await dbContext.SaveChangesAsync();

                var existingAwaymanager = await dbContext.Managers
                  .Where(x => x.Name.Equals(Awaymanager.Name))
                  .FirstOrDefaultAsync();
                if (existingAwaymanager == null)
                {
                    await dbContext.Managers.AddAsync(manager);
                    awayTeam.AwayTeamManagers.Add(manager);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    awayTeam.AwayTeamManagers.Add(existingAwaymanager);
                }
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task<T> AddOrUpdateEntity<T>(ApplicationDbContext dbContext, T entity, Expression<Func<T, bool>> predicate) where T : class
        {
            var existingEntity = await dbContext.Set<T>().Where(predicate).FirstOrDefaultAsync();
            if (existingEntity == null)
            {
                await dbContext.Set<T>().AddAsync(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
            return existingEntity;
        }
    }
}