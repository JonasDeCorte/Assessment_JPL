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

                var existingCountry = await AddOrUpdateCountry(dbContext, match.HomeTeam.Country.Name);
                await AddOrUpdateCompetition(dbContext, match);
                await AddOrUpdateCompetitionStage(dbContext, match);
                await AddOrUpdateSeason(dbContext, match, existingCountry);
                await AddOrUpdateStadium(dbContext, match, existingCountry);
                await AddOrUpdateReferee(dbContext, match, existingCountry);
                await AddOrUpdateHomeTeam(dbContext, match, existingCountry);
                await AddOrUpdateAwayTeam(dbContext, match, existingCountry);

                await dbContext.Matches.AddAsync(match);
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task<Country> AddOrUpdateCountry(ApplicationDbContext dbContext, string countryName)
        {
            var existingCountry = await dbContext.Countries
                .Where(x => x.Name.Equals(countryName))
                .FirstOrDefaultAsync();

            if (existingCountry == null)
            {
                existingCountry = new Country { Name = countryName };
                await dbContext.Countries.AddAsync(existingCountry);
                await dbContext.SaveChangesAsync();
            }

            return existingCountry;
        }

        private static async Task AddOrUpdateCompetition(ApplicationDbContext dbContext, Match match)
        {
            var competition = new Competition
            {
                Name = match.Competition.Name,
                CountryName = match.Competition.CountryName,
            };
            var existingCompetition = await AddOrUpdateEntity(dbContext, competition, x => x.Name.Equals(competition.Name));
            match.CompetitionId = existingCompetition.CompetitionId;
        }

        private static async Task AddOrUpdateCompetitionStage(ApplicationDbContext dbContext, Match match)
        {
            var competitionStage = new CompetitionStage
            {
                Name = match.Competition.Name,
            };
            var existingCompetitionStage = await AddOrUpdateEntity(dbContext, competitionStage, x => x.Name.Equals(competitionStage.Name));
            match.CompetitionStageId = existingCompetitionStage.Id;
            match.CompetitionStage = existingCompetitionStage;
        }

        private static async Task AddOrUpdateSeason(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var season = new Season
            {
                Name = match.Season.Name,
            };
            var existingSeason = await AddOrUpdateEntity(dbContext, season, x => x.Name.Equals(season.Name));
            match.SeasonId = existingSeason.SeasonId;
        }

        private static async Task AddOrUpdateStadium(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var stadium = new Stadium
            {
                Name = match.Competition.Name,
            };
            var existingStadium = await dbContext.Stadiums
                .Where(x => x.Name.Equals(stadium.Name))
                .FirstOrDefaultAsync();

            string stadiumCountryName = match.HomeTeam.Country.Name;
            var existingStadiumCountry = await dbContext.Countries
              .Where(x => x.Name.Equals(stadiumCountryName))
              .FirstOrDefaultAsync();
            if (existingStadiumCountry == null)
            {
                var newCountry = new Country { Name = stadiumCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                stadium.CountryId = newCountry.CountryId;
            }
            else
            {
                stadium.CountryId = existingCountry.CountryId;
            }
            await dbContext.SaveChangesAsync();

            if (existingStadium == null)
            {
                await dbContext.Stadiums.AddAsync(stadium);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                match.StadiumId = existingStadium.StadiumId;
            }
        }

        private static async Task AddOrUpdateReferee(ApplicationDbContext dbContext, Match match, Country existingCountry)
        {
            var referee = new Referee
            {
                Name = match.Competition.Name,
            };

            string refereeCountryName = match.HomeTeam.Country.Name;
            var existingRefereeCountry = await dbContext.Countries
              .Where(x => x.Name.Equals(refereeCountryName))
              .FirstOrDefaultAsync();
            if (existingRefereeCountry == null)
            {
                var newCountry = new Country { Name = refereeCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                referee.CountryId = newCountry.CountryId;
            }
            else
            {
                referee.CountryId = existingCountry.CountryId;
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
                HomeTeamName = match.HomeTeam.HomeTeamName,
                HomeTeamGender = match.HomeTeam.HomeTeamGender,
                HomeTeamYouth = match.HomeTeam.HomeTeamYouth,
            };

            string homeTeamCountryName = match.HomeTeam.Country.Name;
            var existingHomeCountry = await dbContext.Countries
              .Where(x => x.Name.Equals(homeTeamCountryName))
              .FirstOrDefaultAsync();
            if (existingHomeCountry == null)
            {
                var newCountry = new Country { Name = homeTeamCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                homeTeam.CountryId = newCountry.CountryId;
            }
            else
            {
                homeTeam.CountryId = existingCountry.CountryId;
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
                match.HomeTeamId = existingHomeTeam.HomeTeamId;
            }

            foreach (var HTmanager in match.HomeTeam.HomeTeamManagers)
            {
                var manager = new Manager
                {
                    DateOfBirth = HTmanager.DateOfBirth,
                    Name = HTmanager.Name,
                    Nickname = HTmanager.Nickname,
                };

                string htManagerCountryName = HTmanager.Country.Name;
                var existinghtManagerCountry = await dbContext.Countries
                  .Where(x => x.Name.Equals(htManagerCountryName))
                  .FirstOrDefaultAsync();
                if (existinghtManagerCountry == null)
                {
                    var x = new Country { Name = htManagerCountryName };
                    await dbContext.Countries.AddAsync(x);
                    await dbContext.SaveChangesAsync();
                    manager.CountryId = x.CountryId;
                }
                else
                {
                    manager.CountryId = existingCountry.CountryId;
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
                AwayTeamName = match.AwayTeam.AwayTeamName,
                AwayTeamGender = match.AwayTeam.AwayTeamGender,
                AwayTeamYouth = match.AwayTeam.AwayTeamYouth,
            };

            string awayTeamCountryName = match.AwayTeam.Country.Name;
            var existingAwayCountry = await dbContext.Countries
              .Where(x => x.Name.Equals(awayTeamCountryName))
              .FirstOrDefaultAsync();
            if (existingAwayCountry == null)
            {
                var newCountry = new Country { Name = awayTeamCountryName };
                await dbContext.Countries.AddAsync(newCountry);
                await dbContext.SaveChangesAsync();
                awayTeam.CountryId = newCountry.CountryId;
            }
            else
            {
                awayTeam.CountryId = existingCountry.CountryId;
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
                match.AwayTeamId = existingAwayTeam.AwayTeamId;
            }

            foreach (var Awaymanager in match.AwayTeam.AwayTeamManagers)
            {
                var manager = new Manager
                {
                    DateOfBirth = Awaymanager.DateOfBirth,
                    Name = Awaymanager.Name,
                    Nickname = Awaymanager.Nickname,
                };
                string atManagerCountryName = Awaymanager.Country.Name;
                var existingatManagerCountry = await dbContext.Countries
                  .Where(x => x.Name.Equals(atManagerCountryName))
                  .FirstOrDefaultAsync();
                if (existingatManagerCountry == null)
                {
                    var x = new Country { Name = atManagerCountryName };
                    await dbContext.Countries.AddAsync(x);
                    await dbContext.SaveChangesAsync();
                    manager.CountryId = x.CountryId;
                }
                else
                {
                    manager.CountryId = existingCountry.CountryId;
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