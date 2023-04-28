using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class AwayTeamType : ObjectType<AwayTeam>
    {
        protected override void Configure(IObjectTypeDescriptor<AwayTeam> descriptor)
        {
            descriptor.Field(at => at.AwayTeamId).Type<NonNullType<IdType>>();
            descriptor.Field(at => at.AwayTeamName).Type<NonNullType<StringType>>();
            descriptor.Field(at => at.AwayTeamGender).Type<NonNullType<StringType>>();
            descriptor.Field(at => at.AwayTeamYouth).Type<NonNullType<BooleanType>>();
            descriptor.Field(at => at.AwayTeamGroup).Type<StringType>();
            descriptor.Field(at => at.Country).Type<NonNullType<CountryType>>();
            descriptor.Field(at => at.AwayTeamManagers).Type<NonNullType<ListType<NonNullType<ManagerType>>>>();
        }
    }
}