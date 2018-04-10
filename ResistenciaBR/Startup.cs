using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResistenciaBR.Startup))]
namespace ResistenciaBR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
