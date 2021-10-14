using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica_7___Ejercicios.Startup))]
namespace Practica_7___Ejercicios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
