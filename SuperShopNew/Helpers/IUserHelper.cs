namespace SuperShopNew.Helpers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using SuperShopNew.Data.Entities;
    using SuperShopNew.Models;

    public interface IUserHelper
    {
        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<User> GetUserByEmailAsync(string email);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
