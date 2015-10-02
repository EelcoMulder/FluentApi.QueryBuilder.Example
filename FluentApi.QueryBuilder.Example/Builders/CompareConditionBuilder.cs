using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders.Interfaces;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders
{
    public class CompareConditionBuilder : ICheckIfCompare, IIs
    {
        private readonly Query _query;
        private readonly QueryBuilder _queryBuilder;
        private readonly CompareCondition _compareCondition = new CompareCondition();
        public CompareConditionBuilder(Query query, QueryBuilder queryBuilder)
        {
            _query = query;
            _queryBuilder = queryBuilder;
        }

        public IIs CheckIf(string columnName)
        {
            _compareCondition.Column = columnName;
            return this;
        }
        public QueryBuilder Is(CompareType compareType, string value)
        {
            _compareCondition.Compare = compareType;
            _compareCondition.Value = value;
            _query.Conditions.Add(_compareCondition);
            return _queryBuilder;
        }
    }
}
