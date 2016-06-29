using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitProject.Startup))]
namespace MyGitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
