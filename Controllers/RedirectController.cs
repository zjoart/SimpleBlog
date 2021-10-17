using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Controllers
{
    public class RedirectController : Controller
    {

        [AllowAnonymous]
        [Route("Identity/Account/Login")]
        public IActionResult LoginRedirect(string ReturnUrl)
        {
            return Redirect("/admin/login?ReturnUrl=" + Url.Content($"~{ReturnUrl}"));

        }

        //https://localhost:44397/Identity/Account/Login?ReturnUrl=%2Fcreate
    }
}
