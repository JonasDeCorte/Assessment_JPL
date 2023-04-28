using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class RefereeType : ObjectType<Referee>
    {
        protected override void Configure(IObjectTypeDescriptor<Referee> descriptor)
        {
            descriptor.Field(r => r.RefereeId).Type<NonNullType<IdType>>();
            descriptor.Field(r => r.Name).Type<NonNullType<StringType>>();
            descriptor.Field(r => r.Country).Type<NonNullType<CountryType>>();
        }
    }
}