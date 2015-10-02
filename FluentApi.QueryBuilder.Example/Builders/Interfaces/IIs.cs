using FluentApi.QueryBuilder.Example.Entities;

namespace FluentApi.QueryBuilder.Example.Builders.Interfaces
{
    public interface IIs
    {
        QueryBuilder Is(CompareType compareType, string value);
    }
}