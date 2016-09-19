using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAffectationsConversion.Startup))]
namespace WebAffectationsConversion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
