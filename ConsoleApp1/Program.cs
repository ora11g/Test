using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartElk.Antler.NHibernate.Configuration;
using SmartElk.Antler.NHibernate;
using SmartElk.Antler.Core;
using FluentNHibernate.Cfg.Db;
using SmartElk.Antler.Core.Abstractions.Configuration;
using SmartElk.Antler.Windsor;
using System.Reflection;
using Castle.Windsor;
using HisPlus.Contract;
using HisPlus.Service;
using Castle.MicroKernel.Registration;

namespace ConsoleApp1
{
    class Program
    {
        public static IAntlerConfigurator AntlerConfigurator { get; private set; }

        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IBsGfxeService>().ImplementedBy<BsGfxeService>().LifestyleSingleton());

            const string connectionString = "Data Source=localhost;Initial Catalog=HIS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            AntlerConfigurator = new AntlerConfigurator();

            AntlerConfigurator.UseWindsorContainer(container)
                              .UseStorage(NHibernateStorage.Use.WithDatabaseConfiguration(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql())
                                            .WithMappings(Assembly.Load("HisPlus-Mapping")));

            var service = container.Resolve<IBsGfxeService>();
            var model =  service.GetById(2);
            Console.ReadLine();
        }
    }
}
