using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders.Interfaces;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders
{
    public class OrderByBuilder : ISetOrderOn, IAndDirectionTo
    {
        private readonly Query _query;
        private readonly QueryBuilder _queryBuilder;
        private readonly OrderBy _orderBy = new OrderBy();
        public OrderByBuilder(Query query, QueryBuilder queryBuilder)
        {
            _query = query;
            _queryBuilder = queryBuilder;
        }

        public IAndDirectionTo SetOrderOn(string column)
        {
            _orderBy.Column = column;
            return this;
        }

        public QueryBuilder AndDirectionTo(OrderByDirection orderByDirection)
        {
            _orderBy.Direction = orderByDirection;
            _query.OrderBys.Add(_orderBy);
            return _queryBuilder;
        }
    }
}
