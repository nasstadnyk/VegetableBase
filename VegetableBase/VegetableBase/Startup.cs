using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VegetableBase.Startup))]
namespace VegetableBase
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
