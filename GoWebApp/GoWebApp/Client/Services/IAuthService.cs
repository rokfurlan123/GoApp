using GoWebApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWebApp.Client.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(ProfileRegister request);
        Task<ServiceResponse<string>> Login(ProfileLogIn request);
    }
}
