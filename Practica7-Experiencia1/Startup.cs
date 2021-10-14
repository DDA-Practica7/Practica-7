using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica7_Experiencia1.Startup))]
namespace Practica7_Experiencia1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
