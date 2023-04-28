using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class StadiumType : ObjectType<Stadium>
    {
        protected override void Configure(IObjectTypeDescriptor<Stadium> descriptor)
        {
            descriptor.Field(s => s.StadiumId).Type<NonNullType<IdType>>();
            descriptor.Field(s => s.Name).Type<NonNullType<StringType>>();
            descriptor.Field(s => s.Country).Type<NonNullType<CountryType>>();
        }
    }
}