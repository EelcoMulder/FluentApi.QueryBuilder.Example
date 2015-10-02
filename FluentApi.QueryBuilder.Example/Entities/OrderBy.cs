using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.QueryBuilder.Example.Entities
{
    public enum OrderByDirection
    {
        Ascending,
        Descending
    }
    public class OrderBy
    {
        public string Column { get; set; }
        public OrderByDirection Direction { get; set; }
    }
}
