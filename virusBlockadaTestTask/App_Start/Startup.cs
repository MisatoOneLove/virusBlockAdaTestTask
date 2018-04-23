using BusinessLogic;
using BusinessLogic.Services;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using virusBlockadaTestTask;

[assembly: OwinStartup(typeof(Startup))]

namespace virusBlockadaTestTask
{
    public class Startup
    {
        readonly IServiceCreator _serviceCreator = new ServiceCreator();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        public IUserService CreateUserService()
        {
            return _serviceCreator.CreateUserService();
        }
    }
}