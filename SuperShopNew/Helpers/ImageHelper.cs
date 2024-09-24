namespace SuperShopNew.Helpers
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public class ImageHelper : IImageHelper
    {
        public async Task<Guid> UploadImageAsync(IFormFile imageFile, string folder) 
        { 
            Guid imageId = Guid.NewGuid();
            string file = $"{imageId}.jpg";

            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot\\images\\{folder}",
                file);

            using (FileStream stream = new FileStream(path, FileMode.Create)) 
            { 
                await imageFile.CopyToAsync(stream);
            }

            return imageId;
        }
    }
}
