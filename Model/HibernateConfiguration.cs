﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using System.IO;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Conventions.Helpers;

namespace Model
{
    public class HibernateConfiguration
    {

        private static ISessionFactory _sessionFactory;


        public static ISession GetSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = GetSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        private static ISessionFactory GetSessionFactory()
        {
            try
            {
                return Fluently.Configure()
                    .Database(
                      MySQLConfiguration.Standard.ConnectionString(c => c
                        .Server("23133.m.tld.pl")
                        .Database("baza23133_testdotnet")
                        .Username("admin23133_testdotnet")
                        .Password("2GgI6VA#K2")
                    ))
                    .Mappings(m =>
                      m.FluentMappings.AddFromAssemblyOf<HibernateConfiguration>()/*.Conventions.Add(DefaultLazy.Never())*/)
                    //.ExposeConfiguration(cfg => BuildSchema(cfg) )
                    .BuildSessionFactory();
            }
            catch (Exception exception)
            {
                
                throw exception.InnerException;
            }
            
        }

        private static void BuildSchema(Configuration config)
        {
            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
              .Create(false, true);
        }
    }
}
