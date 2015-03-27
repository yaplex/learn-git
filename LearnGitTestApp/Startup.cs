using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnGitTestApp.Startup))]
namespace LearnGitTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
