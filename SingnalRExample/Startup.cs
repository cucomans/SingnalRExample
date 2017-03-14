using System;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(SingnalRExample.Startup))]

namespace SingnalRExample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}