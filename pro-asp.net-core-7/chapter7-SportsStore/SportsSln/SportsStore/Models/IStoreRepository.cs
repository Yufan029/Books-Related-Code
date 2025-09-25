namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        // IQueryable only retrieve the one we want, like when pagination
        // Whereas IEnumerable will get all the items in the database then filter out the ones that we don't want
        // IQueryable more efficient,
        // HOWEVER,
        // when the IQueryable collection enumerated, the query will be evaluated again, (query send to database)
        // this may undermine the efficiency gains frm IQueryable.
        // So use ToList or ToArray to convert IQueryable<T> result into more predictable form.
        IQueryable<Product> Products { get; }

        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
