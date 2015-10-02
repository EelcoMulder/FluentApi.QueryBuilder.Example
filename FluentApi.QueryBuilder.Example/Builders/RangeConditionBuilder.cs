using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders.Interfaces;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders
{
    public class RangeConditionBuilder : ICheckIfRange, IFrom, ITo
    {
        private readonly Query _query;
        private readonly QueryBuilder _queryBuilder;
        private readonly RangeCondition _rangeCondition = new RangeCondition();
        public RangeConditionBuilder(Query query, QueryBuilder queryBuilder)
        {
            _query = query;
            _queryBuilder = queryBuilder;
        }
        public IFrom CheckIf(string columnName)
        {
            _rangeCondition.Column = columnName;
            return this;
        }

        public ITo From(int @from)
        {
            _rangeCondition.From = @from;
            return this;
        }

        public QueryBuilder To(int to)
        {
            _rangeCondition.To = to;
            _query.Conditions.Add(_rangeCondition);
            return _queryBuilder;
        }
    }
}
