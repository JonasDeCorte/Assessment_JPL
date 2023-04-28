using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class ManagerType : ObjectType<Manager>
    {
        protected override void Configure(IObjectTypeDescriptor<Manager> descriptor)
        {
            descriptor.Field(m => m.ManagerId).Type<NonNullType<IdType>>();
            descriptor.Field(m => m.Name).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.Nickname).Type<StringType>();
            descriptor.Field(m => m.DateOfBirth).Type<NonNullType<StringType>>();
            descriptor.Field(m => m.Country).Type<NonNullType<CountryType>>();
        }
    }
}