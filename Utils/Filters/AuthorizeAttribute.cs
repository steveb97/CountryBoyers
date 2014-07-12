using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountryBoyers.Utils.Filters
{
  public class AuthorizeAttribute : System.Web.Mvc.AuthorizeAttribute
  {
    protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
    {
      base.HandleUnauthorizedRequest(filterContext);

      if (HttpContext.Current.User.Identity.IsAuthenticated)
      {
        filterContext.Result = new ViewResult { ViewName = MVC.Shared.Views.Unauthorized };
      }
    }
  }
}