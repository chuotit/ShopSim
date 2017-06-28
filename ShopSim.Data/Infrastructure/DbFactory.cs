namespace ShopSim.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopSimDbContext dbContext;

        public ShopSimDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopSimDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}