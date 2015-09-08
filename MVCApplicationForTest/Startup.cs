using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApplicationForTest.Startup))]
namespace MVCApplicationForTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
