using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.QueryBuilder.Example.Entities
{
    public class RangeCondition : ICondition
    {
        public string Column { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
