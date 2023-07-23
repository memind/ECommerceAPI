﻿using ECommerceAPI.Domain.Entities.Identity;
using Dto = ECommerceAPI.Application.DTOs;

namespace ECommerceAPI.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
