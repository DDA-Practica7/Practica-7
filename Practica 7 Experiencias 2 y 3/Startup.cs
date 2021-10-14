using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica_7_Experiencias.Startup))]
namespace Practica_7_Experiencias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
