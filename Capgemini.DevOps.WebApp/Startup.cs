using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capgemini.DevOps.WebApp.Startup))]
namespace Capgemini.DevOps.WebApp
{
    public partial class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
