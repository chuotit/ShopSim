namespace ShopSim.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}