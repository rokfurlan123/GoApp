using GoWebApp.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoWebApp.Client.Services
{
    public interface IGetProfileService
    {
        Task<User> GetProfileInfo();
        Task UpdateProfile(User profile);
        Task<List<string>> GetAllUsers();
    }
}