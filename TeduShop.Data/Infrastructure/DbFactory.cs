namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        public TeduShopDbContext dbContext;

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}