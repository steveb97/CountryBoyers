using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountryBoyers.Startup))]
namespace CountryBoyers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
