namespace ConsoleClient
{
    using ToyStoreModels;

    public interface IEntityInsertor
    {
        void InsertEntities(ToyStoreEntities db);
    }
}
