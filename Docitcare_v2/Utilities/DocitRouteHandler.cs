using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Docitcare_v2.Utilities
{
    public class DocitRouteHandler : IRouteHandler
    {
        IHttpHandler IRouteHandler.GetHttpHandler(RequestContext requestContext)
        {
            return new DocitMvcHandler(requestContext);
        }

        public class DocitMvcHandler : MvcHandler, IHttpHandler
        {
            public DocitMvcHandler(RequestContext requestContext) : base(requestContext)
            {
            }

            private string GetControllerName(HttpContextBase httpContext)
            {
                string controllerName = this.RequestContext.RouteData.GetRequiredString("controller");
                var groupId = httpContext.Session["GroupId"] as string;
                if (!String.IsNullOrEmpty(groupId) && !String.IsNullOrEmpty(controllerName))
                {
                    controllerName = groupId + controllerName;
                }
                return controllerName;
            }

            protected override IAsyncResult BeginProcessRequest(HttpContextBase httpContext, AsyncCallback callback, object state)
            {
                RequestContext.RouteData.Values["controller"] = this.GetControllerName(httpContext);
                return base.BeginProcessRequest(httpContext, callback, state);
            }
        }
    }
}