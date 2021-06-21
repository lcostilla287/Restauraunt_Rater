using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restauraunt_Rater.Startup))]
namespace Restauraunt_Rater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
