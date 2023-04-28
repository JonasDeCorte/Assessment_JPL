using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class HomeTeamType : ObjectType<HomeTeam>
    {
        protected override void Configure(IObjectTypeDescriptor<HomeTeam> descriptor)
        {
            descriptor.Field(ht => ht.HomeTeamId).Type<NonNullType<IdType>>();
            descriptor.Field(ht => ht.HomeTeamName).Type<NonNullType<StringType>>();
            descriptor.Field(ht => ht.HomeTeamGender).Type<NonNullType<StringType>>();
            descriptor.Field(ht => ht.HomeTeamYouth).Type<NonNullType<BooleanType>>();
            descriptor.Field(ht => ht.HomeTeamGroup).Type<StringType>();
            descriptor.Field(ht => ht.Country).Type<NonNullType<CountryType>>();
            descriptor.Field(ht => ht.HomeTeamManagers).Type<NonNullType<ListType<NonNullType<ManagerType>>>>();
        }
    }
}