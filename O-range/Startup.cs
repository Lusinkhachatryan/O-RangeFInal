using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(O_range.Startup))]
namespace O_range
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
