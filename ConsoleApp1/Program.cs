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
using NHibernate;
using FluentNHibernate.Cfg;
using HisPlus.Mapping;
using NHibernate.Cfg;
using NHibernate.Caches.SysCache;

namespace ConsoleApp1
{
    class Program
    {
        //public static IAntlerConfigurator AntlerConfigurator { get; private set; }
        //private static ISessionFactory CreateNhSessionFactory()
        //{
        //    var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["HisPlus"].ConnectionString;
        //    return Fluently.Configure()
        //        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connStr))
        //        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(BsGfxeMap))))
        //        .BuildSessionFactory();
        //}
        static ISessionFactory sessionFactory;

        static Program()
        {
            //            var configuration = new Configuration()
            //    .Cache(x => x.UseQueryCache = true)
            //configuration.SessionFactory()
            //    .Caching.Through<SysCacheProvider>().WithDefaultExpiration(60)

            Configuration config = new Configuration().Configure();
            //var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["HisPlus"].ConnectionString;
            var connStr = "Data Source=localhost;Initial Catalog=HIS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            sessionFactory = Fluently.Configure(config)
                //.Database(MsSqlConfiguration.MsSql2012.ConnectionString(connStr).ShowSql())
                //.Cache(c => c.ProviderClass<SysCacheProvider>().UseQueryCache())
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(BsGfxeMap))))
                .Cache(c =>
                {
                    c.ProviderClass<SysCacheProvider>().UseQueryCache().UseSecondLevelCache();
                    
                }).BuildSessionFactory();
        }

        static void Main(string[] args)
        {
            
            //var container = new WindsorContainer();
            //container.Register(Component.For<IBsGfxeService>().ImplementedBy<BsGfxeService>().LifestyleSingleton());

            //const string connectionString = "Data Source=localhost;Initial Catalog=HIS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            //AntlerConfigurator = new AntlerConfigurator();

            //// configuration.Configure( "path/to/hibernate.cfg.xml" );

            //AntlerConfigurator.UseWindsorContainer(container)
            //                  .UseStorage(NHibernateStorage.Use.WithDatabaseConfiguration(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql()).ApplyOnNHibernateConfiguration((cfg) => { cfg.Configure("./hibernate.cfg.xml"); })
            //                                .WithMappings(Assembly.Load("HisPlus-Mapping")));

            //var service = container.Resolve<IBsGfxeService>();
            var service1 = new BsGfxeService();
            var result1 = service1.GetById(sessionFactory, 2);
          
            Console.WriteLine("result rows: " + service1.Query(sessionFactory).Count());

            //var service1 = container.Resolve<IBsGfxeService>();
            var service2 = new BsGfxeService();
            var result3 = service2.GetById(sessionFactory, 2);
       
            Console.WriteLine("result rows: " + service2.Query(sessionFactory).Count());

            Console.ReadLine();
        }

        public static ISessionFactory Configure()
        {
            return Fluently.Configure()
           //which database
                   .Database(
              MsSqlConfiguration.MsSql2012
           //connection string from app.config
                           .ConnectionString(
                cs => cs.FromConnectionStringWithKey("HisPlus"))
               .ShowSql())
           //2nd level cache
                   .Cache(
              c => c.UseQueryCache()
               .UseSecondLevelCache()
               .ProviderClass<NHibernate.Cache.HashtableCacheProvider>())
           //find the mappings
                   .Mappings(m => m.FluentMappings.AddFromAssemblyOf<BsGfxeMap>())
             .BuildSessionFactory();
        }
    }
}
