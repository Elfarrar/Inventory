﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BaseAPI.Configuration.Identity
{
    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(ClaimFilter))
        {
            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }
}
