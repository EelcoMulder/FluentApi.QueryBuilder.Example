using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // build up query
            Query query1 = WithoutBuilderExample.CreateQuery();
            // build up query
            Query query2 = WithoutBuilderInitializerExample.CreateQuery();
            // build up query using querybuilder
            Query query3 = WithBuilderExample.CreateQuery();
            // we're done
            Console.Write("Created query object structures");
            // wait for keypress
            Console.ReadKey();
        }
    }
}
