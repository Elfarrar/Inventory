using Identity.Models;

namespace Identity.Helpers
{
    public interface IAutenticationHelper
    {
        Task<UserLogged> GenerateJwt(string email);
    }
}
