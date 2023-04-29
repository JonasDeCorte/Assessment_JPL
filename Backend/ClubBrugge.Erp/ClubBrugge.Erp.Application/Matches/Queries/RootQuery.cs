using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Application.Matches.Queries
{
    public class RootQuery : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field("matches")
                .Type<ListType<NonNullType<Domain.Dtos.MatchType>>>()
                .Resolve(async ctx =>
                {
                    var dbContext = ctx.Service<ApplicationDbContext>();
                    var matches = await dbContext.Matches
                        .Include(m => m.Competition)
                        .Include(m => m.Season)
                        .Include(m => m.HomeTeam).ThenInclude(ht => ht.Country)
                        .Include(m => m.HomeTeam).ThenInclude(ht => ht.HomeTeamManagers).ThenInclude(hm => hm.Country)
                        .Include(m => m.AwayTeam).ThenInclude(at => at.Country)
                        .Include(m => m.AwayTeam).ThenInclude(at => at.AwayTeamManagers).ThenInclude(am => am.Country)
                        .Include(m => m.CompetitionStage)
                        .Include(m => m.Stadium).ThenInclude(s => s.Country)
                        .Include(m => m.Referee).ThenInclude(r => r.Country)
                        .ToListAsync();

                    return matches;
                });
            descriptor.Field("matchPlayerStats")
                .Type<ListType<NonNullType<Domain.Dtos.MatchPlayerStatsType>>>()
                .Argument("matchId", a => a.Type<NonNullType<IdType>>())
                .Resolve(async ctx =>
                {
                    var dbContext = ctx.Service<ApplicationDbContext>();
                    var matchId = ctx.ArgumentValue<int>("matchId");
                    var matchPlayerStats = await dbContext.MatchPlayerStats
                        .Where(mps => mps.MatchId == matchId)
                        .ToListAsync();

                    return matchPlayerStats;
                });
        }
    }
}