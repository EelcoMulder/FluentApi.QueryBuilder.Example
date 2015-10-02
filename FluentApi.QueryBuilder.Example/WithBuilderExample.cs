using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example
{
    public class WithBuilderExample
    {
        public static Query CreateQuery()
        {
            Query query = new Builders.QueryBuilder()
                .AddColumn("Column1")
                .AddColumn("Column2")
                .AddColumn("Column3")
                .JoinOnTable("SubTabel1")
                    .WithParentField("MainTableId")
                    .OnChildField("SubTabel1Id")
                .JoinOnTable("SubTabel2")
                    .WithParentField("MainTableId")
                    .OnChildField("SubTabel2Id")
                .AddRangeCondition()
                    .CheckIf("Column1")
                    .From(10)
                    .To(40)
                .AddCompareCondition()
                    .CheckIf("Column2")
                    .Is(CompareType.Equal, "SomeValue")
                .AddOrderBy()
                    .SetOrderOn("Column1")
                    .AndDirectionTo(OrderByDirection.Ascending)
                .AddOrderBy()
                    .SetOrderOn("Column2")
                    .AndDirectionTo(OrderByDirection.Descending)
                .Done();
            return query;
        }
    }
}
