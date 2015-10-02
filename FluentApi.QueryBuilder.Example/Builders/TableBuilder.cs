using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Builders.Interfaces;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders
{
    public class TableBuilder : IJoinOnTable, IWithParentField, IOnChildField
    {
        private readonly Query _query;
        private readonly QueryBuilder _queryBuilder;
        private readonly Table _table = new Table();
        public TableBuilder(Query query, QueryBuilder queryBuilder)
        {
            _query = query;
            _queryBuilder = queryBuilder;
        }

        public IWithParentField JoinOnTable(string tableName)
        {
            _table.TableName = tableName;
            return this;
        }

        public IOnChildField WithParentField(string parentField)
        {
            _table.ParenKey = parentField;
            return this;
        }

        public QueryBuilder OnChildField(string childField)
        {
            _table.ChildKey = childField;
            _query.Tables.Add(_table);
            return _queryBuilder;
        }
    }
}
