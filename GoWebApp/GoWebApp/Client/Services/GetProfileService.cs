using GoWebApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GoWebApp.Client.Services
{
    public class GetProfileService : IGetProfileService
    {
        private readonly HttpClient _http;

        public GetProfileService(HttpClient http)
        {
            _http = http;
        }

        public async Task<User> GetProfileInfo()
        {
            var user = await _http.GetFromJsonAsync<User>("api/User/GetUser");
            return user;
        }

        public async Task UpdateProfile(User profile)
        {
            var response = await _http.PutAsJsonAsync<User>($"api/User/{profile.Id}", profile);
        }
    }
}
