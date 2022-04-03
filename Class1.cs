using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(Domasno3.Class1))]
namespace Domasno3
{
    public class Class1
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}