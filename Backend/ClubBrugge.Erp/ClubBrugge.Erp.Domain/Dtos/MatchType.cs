using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class MatchType : ObjectType<Match>
    {
        protected override void Configure(IObjectTypeDescriptor<Match> descriptor)
        {
            descriptor.Field(m => m.MatchId).Type<NonNullType<IdType>>();
            descriptor.Field(m => m.MatchDate).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.KickOff).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.Competition).Type<NonNullType<CompetitionType>>();
            descriptor.Field(m => m.Season).Type<NonNullType<SeasonType>>();
            descriptor.Field(m => m.HomeTeam).Type<NonNullType<HomeTeamType>>();
            descriptor.Field(m => m.AwayTeam).Type<NonNullType<AwayTeamType>>();
            descriptor.Field(m => m.HomeScore).Type<NonNullType<IntType>>();
            descriptor.Field(m => m.AwayScore).Type<NonNullType<IntType>>();
            descriptor.Field(m => m.Attendance).Type<IntType>();
            descriptor.Field(m => m.MatchWeek).Type<IntType>();
            descriptor.Field(m => m.BehindClosedDoors).Type<NonNullType<BooleanType>>();
            descriptor.Field(m => m.NeutralGround).Type<NonNullType<BooleanType>>();
            descriptor.Field(m => m.PlayStatus).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.MatchStatus).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.MatchStatus360).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.LastUpdated).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.LastUpdated360).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.CompetitionStage).Type<NonNullType<CompetitionStageType>>();
            descriptor.Field(m => m.Stadium).Type<NonNullType<StadiumType>>();
            descriptor.Field(m => m.Referee).Type<NonNullType<RefereeType>>();
        }
    }
}