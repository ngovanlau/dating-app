﻿using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPrincipleExtentions
{
    public static string GetUserName(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new Exception("Cannot get username from token");

        return username;
    }
}
