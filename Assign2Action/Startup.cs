using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign2Action.Startup))]
namespace Assign2Action
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
