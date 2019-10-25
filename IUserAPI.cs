using Refit;
using System.Threading.Tasks;

namespace TesteApiRefit
{
    public interface IUserAPI
    {
        [Headers("User-Agent: EwertonBello")]
        [Get("/users/{user}")]
        Task<UserResponse> GetUser(string user);
    }
}
