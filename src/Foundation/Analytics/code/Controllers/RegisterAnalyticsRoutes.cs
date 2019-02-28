﻿using Sitecore.Pipelines;
using System.Web.Http;

namespace SF.Foundation.Analytics
{
    public class RegisterAnalyticsRoutes : RegisterRoutesBase
    {
        public void Process(PipelineArgs args)
        {

            GlobalConfiguration.Configure(this.Configure);
        }

        protected void Configure(HttpConfiguration configuration)
        {
            MapRouteWithSession(configuration, "SF.Analytics", "api/sf/1.0/analytics/{action}", "Analytics", "index");
        }
    }
}
