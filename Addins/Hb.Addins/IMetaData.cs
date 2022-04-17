namespace Hb.Addins
{
    public interface IMetaData
    {
        string Id { get; }

        int Index { get; }

        string Name { get; }

        ImportType ImportType { get; }
    }
}
