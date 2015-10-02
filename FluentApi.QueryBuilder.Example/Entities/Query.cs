using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.QueryBuilder.Example.Entities
{
    public class Query
    {
        public string TableName { get; set; }
        public IList<string> Columns { get; set; } = new List<string>();
        public IList<Table> Tables { get; set; } = new List<Table>();
        public IList<ICondition> Conditions { get; set; } = new List<ICondition>();
        public IList<OrderBy> OrderBys { get; set; } = new List<OrderBy>();
    }
}
