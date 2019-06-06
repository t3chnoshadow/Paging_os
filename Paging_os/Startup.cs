using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paging_os.Startup))]
namespace Paging_os
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
