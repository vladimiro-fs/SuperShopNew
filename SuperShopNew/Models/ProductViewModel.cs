namespace SuperShopNew.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using SuperShopNew.Data.Entities;

    public class ProductViewModel : Product
    {
        [Display(Name ="Image")]
        public IFormFile ImageFile { get; set; }
    }
}
