using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example
{
    public class WithoutBuilderInitializerExample
    {
        public static Query CreateQuery()
        {
            Query query = new Query();
            query.TableName = "MainTable";
            query.Columns.Add("Column1");
            query.Columns.Add("Column2");
            query.Columns.Add("Column3");
            Table subTable1 = new Table();
            subTable1.TableName = "SubTabel1";
            subTable1.ParenKey = "MainTableId";
            subTable1.ChildKey = "SubTabel1Id";
            Table subTable2 = new Table();
            subTable2.TableName = "SubTabel2";
            subTable2.ParenKey = "MainTableId";
            subTable2.ChildKey = "SubTabel2Id";
            query.Tables.Add(subTable1);
            query.Tables.Add(subTable2);
            RangeCondition rangeCondition = new RangeCondition();
            rangeCondition.Column = "Column1";
            rangeCondition.From = 10;
            rangeCondition.To = 40;
            query.Conditions.Add(rangeCondition);
            CompareCondition compareCondition = new CompareCondition();
            compareCondition.Column = "Column2";
            compareCondition.Compare = CompareType.Equal;
            compareCondition.Value = "SomeValue";
            query.Conditions.Add(compareCondition);
            OrderBy orderBy1 = new OrderBy();
            orderBy1.Column = "Column1";
            orderBy1.Direction = OrderByDirection.Ascending;
            OrderBy orderBy2 = new OrderBy();
            orderBy2.Column = "Column2";
            orderBy2.Direction = OrderByDirection.Descending;
            query.OrderBys.Add(orderBy1);
            query.OrderBys.Add(orderBy2);
            return query;
        }
    }
}
