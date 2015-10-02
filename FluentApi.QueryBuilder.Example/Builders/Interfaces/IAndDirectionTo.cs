using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders.Interfaces
{
    public interface IAndDirectionTo
    {
        QueryBuilder AndDirectionTo(OrderByDirection orderByDirection);
    }
}