
namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public IQueryable<Product> Products => this.context.Products;


        public EFStoreRepository(StoreDbContext ctx)
        {
            this.context = ctx;
        }
    }
}
