﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNCOMs.WebUI.Startup))]
namespace DNCOMs.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
