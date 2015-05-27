using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanielGrahamHomeEx.Startup))]
namespace DanielGrahamHomeEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
