namespace SuperShopNew.Helpers
{
    using System;
    using SuperShopNew.Data.Entities;
    using SuperShopNew.Models;

    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel mode, Guid imageId, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
