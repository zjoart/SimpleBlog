using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SimpleBlog.Helpers.Filters
{
    public class BlockFilter : IAuthorizationFilter
    {

        public BlockFilter()
        {
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.Result = new RedirectResult("/"); //Redirect to you desired page

        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BlockAttribute : TypeFilterAttribute
    {
        public BlockAttribute() : base(typeof(BlockFilter))
        {
        }
    }

   
}
