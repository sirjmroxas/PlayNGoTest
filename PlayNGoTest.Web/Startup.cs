using Microsoft.Owin;
using Owin;

namespace PlayNGoTest.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
