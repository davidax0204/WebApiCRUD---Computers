using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiCRUD___Computers.Startup))]
namespace WebApiCRUD___Computers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
