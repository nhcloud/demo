﻿using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Rbac.Api.Extensions;
using Rbac.Api.Model;

namespace Rbac.Api.Filters;

public class ValidateRequestFilter : ActionFilterAttribute
{
    //public override void OnActionExecuting(ActionExecutingContext context)
    //{
    //    if (string.IsNullOrEmpty(context.HttpContext.Request.Headers.Authorization))
    //    {
    //        context.Result = new BadRequestObjectResult("Unauthorized access.");
    //        return;
    //    }

    //    if (context.ModelState.IsValid)
    //    {
    //        var auth = context.HttpContext.Request.Headers.Authorization.ToString().Replace("Bearer ", "");
    //        var jwtToken = new JwtSecurityToken(auth);
    //        if (jwtToken.ValidTo <= DateTime.UtcNow)
    //        {
    //            context.Result = new BadRequestObjectResult("Invalid authorization token.");
    //        }
    //        return;
    //    }
    //}
}