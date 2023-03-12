using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuongQuangTung_2080600795_BigSchool.Startup))]
namespace VuongQuangTung_2080600795_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
