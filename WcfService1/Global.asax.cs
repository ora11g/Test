using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ClassLibrary1;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WcfService1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            BuildContainer();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        private void BuildContainer()
        {
            var Container = new WindsorContainer();
            Container.Kernel.AddFacility<WcfFacility>();
            Container.Kernel.Register(Component.For<IStringReverser>()
                                               .ImplementedBy<StringReverser>()
                                               .Named("StringReverserService"));

            Container.Kernel.Register(Component.For<ITest>()
                                               .ImplementedBy<Test>()
                                               .Named("TestService"));
        }


        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}