using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d = ECommerceAPI.Application.DTOs;

namespace ECommerceAPI.Application.Abstractions.Services.Authentication
{
    public interface IExternalAuthentication
    {
        Task<d.Token> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<d.Token> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}
