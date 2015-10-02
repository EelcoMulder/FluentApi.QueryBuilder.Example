namespace FluentApi.QueryBuilder.Example.Builders.Interfaces
{
    public interface ISetOrderOn
    {
        IAndDirectionTo SetOrderOn(string column);
    }
}