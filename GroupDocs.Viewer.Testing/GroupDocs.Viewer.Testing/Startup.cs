using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupDocs.Viewer.Testing.Startup))]
namespace GroupDocs.Viewer.Testing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
