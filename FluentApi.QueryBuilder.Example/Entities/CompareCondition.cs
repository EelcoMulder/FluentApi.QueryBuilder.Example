using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.QueryBuilder.Example.Entities
{
    public enum CompareType
    {
        Equal,
        NotEqual,
        LessThen,
        LessThenEqual,
        GreaterThen,
        GreaterThenEqual
    }
    public class CompareCondition : ICondition
    {
        public string Column { get; set; }
        public CompareType Compare { get; set; }
        public string Value { get; set; }
    }
}
