using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = GetContainer();
            var reverser = container.Resolve<IStringReverser>();
            var test = container.Resolve<ITest>();

            while (true)
            {
                var input = Console.ReadLine();
                var output = reverser.Reverse(new ReverseRequest { Text = input });
                Console.WriteLine(output.Text);

                Console.WriteLine(test.GetString());
            }

        }

        private static WindsorContainer GetContainer()
        {
            var container = new WindsorContainer();
            container.Kernel.AddFacility<WcfFacility>();
            container.Register(Component.For<IStringReverser>()
                                   .AsWcfClient(new DefaultClientModel
                                   {
                                       Endpoint = WcfEndpoint.BoundTo(new BasicHttpBinding())
                                           .At("http://localhost:4679/StringReverser.svc")
                                   }).Named("StringReverserService"));

            container.Register(Component.For<ITest>()
                                   .AsWcfClient(new DefaultClientModel
                                   {
                                       Endpoint = WcfEndpoint.BoundTo(new BasicHttpBinding())
                                           .At("http://localhost:4679/Test.svc")
                                   }).Named("TestService"));
            return container;
        }

    }
}
