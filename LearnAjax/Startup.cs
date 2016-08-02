using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnAjax.Startup))]
namespace LearnAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
