using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders.Interfaces;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders
{
    public class QueryBuilder
    {
        private readonly Query _query = new Query();
        /// <summary>
        /// Set table name
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public QueryBuilder OnTable(string tableName)
        {
            _query.TableName = tableName;
            return this;
        }
        /// <summary>
        /// Add column
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public QueryBuilder AddColumn(string columnName)
        {
            _query.Columns.Add(columnName);
            return this;
        }
        /// <summary>
        /// Add a joined table
        /// </summary>
        /// <returns></returns>
        public IWithParentField JoinOnTable(string tableName)
        {
            TableBuilder tableBuilder = new TableBuilder(_query, this);
            tableBuilder.JoinOnTable(tableName);
            return tableBuilder;
        }
        /// <summary>
        /// Add range condition
        /// </summary>
        /// <returns></returns>
        public ICheckIfRange AddRangeCondition()
        {
            RangeConditionBuilder rangeConditionBuilder = new RangeConditionBuilder(_query, this);
            return rangeConditionBuilder;
        }
        /// <summary>
        /// Add compare condition
        /// </summary>
        /// <returns></returns>
        public ICheckIfCompare AddCompareCondition()
        {
            CompareConditionBuilder compareConditionBuilder = new CompareConditionBuilder(_query, this);
            return compareConditionBuilder;
        }
        /// <summary>
        /// Return order by builder, first we want the set order on method
        /// </summary>
        /// <returns></returns>
        public ISetOrderOn AddOrderBy()
        {
            OrderByBuilder orderByBuilder = new OrderByBuilder(_query, this);
            return orderByBuilder;
        }
        /// <summary>
        /// Signal we're done
        /// </summary>
        /// <returns></returns>
        public Query Done()
        {
            return _query;
        }
    }
}
