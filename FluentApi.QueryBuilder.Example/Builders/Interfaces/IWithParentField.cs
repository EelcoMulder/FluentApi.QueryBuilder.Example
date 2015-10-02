namespace FluentApi.QueryBuilder.Example.Builders.Interfaces
{
    public interface IWithParentField
    {
        IOnChildField WithParentField(string parentField);
    }
}