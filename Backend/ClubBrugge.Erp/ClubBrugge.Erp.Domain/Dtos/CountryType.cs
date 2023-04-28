using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class CountryType : ObjectType<Country>
    {
        protected override void Configure(IObjectTypeDescriptor<Country> descriptor)
        {
            descriptor.Field(c => c.CountryId).Type<NonNullType<IdType>>();
            descriptor.Field(c => c.Name).Type<NonNullType<StringType>>();
        }
    }
}