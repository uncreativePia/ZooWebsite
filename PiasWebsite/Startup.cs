using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiasWebsite.Startup))]
namespace PiasWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			Zoo.AddTiere();
			Zoo.AddMitarbeiter();
			Zoo.AddGehege(); 
        }
    }
}
