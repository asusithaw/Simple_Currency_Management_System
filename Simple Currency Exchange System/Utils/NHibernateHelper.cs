using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using Simple_Currency_Exchange_System.Mapping;
using System.Reflection;

namespace Simple_Currency_Exchange_System
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        [ThreadStatic]
        private static ISession _session;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    try
                    {
                        _sessionFactory = Fluently.Configure()
                            .Database(MySQLConfiguration.Standard
                                .ConnectionString(@"Server=localhost;Database=currencyexchange;User Id=root;Password=root123;")
                                .ShowSql())
                            .Mappings(m =>
                            {
                                var assembly = typeof(NHibernateHelper).Assembly;
                                var mappingTypes = assembly.GetTypes()
                                    .Where(t => typeof(IFluentMapping).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                                    .ToArray();

                                foreach (var type in mappingTypes)
                                {
                                    m.FluentMappings.Add(type);
                                }
                            })
                            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                            .BuildSessionFactory();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                        if (ex.InnerException != null)
                        {
                            Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                        }
                        throw;
                    }
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            if (_session == null || !_session.IsOpen)
            {
                _session = SessionFactory.OpenSession();
            }
            return _session;
        }

        public static void CloseSession()
        {
            if (_session != null && _session.IsOpen)
            {
                _session.Close();
                _session.Dispose();
                _session = null;
            }
        }
    }
}
