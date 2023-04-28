using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class CompetitionType : ObjectType<Competition>
    {
        protected override void Configure(IObjectTypeDescriptor<Competition> descriptor)
        {
            descriptor.Field(c => c.CompetitionId).Type<NonNullType<IdType>>();
            descriptor.Field(c => c.Name).Type<NonNullType<StringType>>();
            descriptor.Field(c => c.CountryName).Type<NonNullType<StringType>>();
        }
    }
}