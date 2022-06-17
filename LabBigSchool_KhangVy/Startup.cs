using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_KhangVy.Startup))]
namespace LabBigSchool_KhangVy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
