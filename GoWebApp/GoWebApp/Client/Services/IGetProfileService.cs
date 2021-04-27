using GoWebApp.Shared;
using System.Threading.Tasks;

namespace GoWebApp.Client.Services
{
    public interface IGetProfileService
    {
        Task<User> GetProfileInfo();
        Task UpdateProfile(User profile);
    }
}