namespace FluentApi.QueryBuilder.Example.Builders.Interfaces
{
    public interface IJoinOnTable
    {
        IWithParentField JoinOnTable(string tableName);
    }
}