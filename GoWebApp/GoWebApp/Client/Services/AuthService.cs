﻿using GoWebApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GoWebApp.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<int>> Register(ProfileRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/Auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>(); 
        }

        public async Task<ServiceResponse<string>> Login(ProfileLogIn request)
        {
            var result = await _http.PostAsJsonAsync("api/Auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
    }
}
