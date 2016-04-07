using Cubit.App_Start;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cubit.Startup))]
namespace Cubit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ContainerConfig.RegisterTypes();
        }
    }
}
