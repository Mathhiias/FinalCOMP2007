using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalA.Startup))]
namespace FinalA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
