namespace SuperShopNew.Data
{
    using System.Linq;
    using SuperShopNew.Data.Entities;

    public interface IProductRepository : IGenericRepository<Product> 
    {
        IQueryable GetAllWithUsers();
    }
}
