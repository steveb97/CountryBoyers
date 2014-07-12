using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountryBoyers.Utils.Filters
{
  public class ClaimsAuthorizeAttribute : AuthorizeAttribute
  {
    private string claimType;
    private string[] claimValues;
    
    public ClaimsAuthorizeAttribute(string type, params string[] values)
    {
      this.claimType = type;
      this.claimValues = values;
    }

    public override void OnAuthorization(AuthorizationContext filterContext)
    {
      var user = HttpContext.Current.User as System.Security.Claims.ClaimsPrincipal;
      
      if (claimValues.Any(claimValue => user.HasClaim(claimType, claimValue)))
      {
        base.OnAuthorization(filterContext);
      }
      else
      {
        HandleUnauthorizedRequest(filterContext);
      }
    }
  }
}