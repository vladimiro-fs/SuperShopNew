namespace SuperShopNew.Helpers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public interface IImageHelper
    {
        Task<Guid> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
