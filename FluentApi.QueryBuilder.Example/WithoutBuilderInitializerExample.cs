using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example
{
    class WithoutBuilderExample
    {
        public static Query CreateQuery()
        {
            Query query = new Query {TableName = "MainTable"};
            query.Columns.Add("Column1");
            query.Columns.Add("Column2");
            query.Columns.Add("Column3");
            Table subTable1 = new Table
            {
                TableName = "SubTabel1",
                ParenKey = "MainTableId",
                ChildKey = "SubTabel1Id"
            };
            Table subTable2 = new Table
            {
                TableName = "SubTabel2",
                ParenKey = "MainTableId",
                ChildKey = "SubTabel2Id"
            };
            query.Tables.Add(subTable1);
            query.Tables.Add(subTable2);
            RangeCondition rangeCondition = new RangeCondition
            {
                Column = "Column1",
                From = 10,
                To = 40
            };
            CompareCondition compareCondition = new CompareCondition
            {
                Column = "Column2",
                Compare = CompareType.Equal,
                Value = "SomeValue"
            };
            query.Conditions.Add(rangeCondition);
            query.Conditions.Add(compareCondition);
            OrderBy orderBy1 = new OrderBy
            {
                Column = "Column1",
                Direction = OrderByDirection.Ascending
            };
            OrderBy orderBy2 = new OrderBy
            {
                Column = "Column2",
                Direction = OrderByDirection.Descending
            };
            query.OrderBys.Add(orderBy1);
            query.OrderBys.Add(orderBy2);
            return query;
        }
    }
}
