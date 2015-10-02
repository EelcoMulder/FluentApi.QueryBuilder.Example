using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.QueryBuilder.Example.Entities
{
    public class Table
    {
        public string TableName { get; set; }
        public string ParenKey { get; set; }
        public string ChildKey { get; set; }
    }
}
