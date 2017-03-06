using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventoryManagement.Startup))]
namespace InventoryManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
