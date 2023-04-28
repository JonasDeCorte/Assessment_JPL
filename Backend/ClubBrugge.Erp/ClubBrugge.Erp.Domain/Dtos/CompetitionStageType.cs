using ClubBrugge.Erp.Domain.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Domain.Dtos
{
    public class CompetitionStageType : ObjectType<CompetitionStage>
    {
        protected override void Configure(IObjectTypeDescriptor<CompetitionStage> descriptor)
        {
            descriptor.Field(cs => cs.Id).Type<NonNullType<IdType>>();
            descriptor.Field(cs => cs.Name).Type<NonNullType<StringType>>();
        }
    }
}