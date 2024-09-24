namespace SuperShopNew.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SuperShopNew.Data.Entities;

    public interface IProductRepository : IGenericRepository<Product> 
    {
        IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
