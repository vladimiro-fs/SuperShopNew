namespace SuperShopNew.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using SuperShopNew.Data.Entities;

    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task <IQueryable<Order>> GetOrderAsync(string userName); 

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);


    }
}
