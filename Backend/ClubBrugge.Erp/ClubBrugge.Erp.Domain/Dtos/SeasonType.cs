using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class SeasonType : ObjectType<Season>
    {
        protected override void Configure(IObjectTypeDescriptor<Season> descriptor)
        {
            descriptor.Field(s => s.SeasonId).Type<NonNullType<IdType>>();
            descriptor.Field(s => s.Name).Type<NonNullType<StringType>>();
        }
    }
}