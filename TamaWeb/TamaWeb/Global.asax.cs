using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using TamaWeb.Models;
using TamaWeb.Spelregels;

namespace TamaWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TamagotchiContext>());
            
            var clocktype = ConfigurationManager.AppSettings["tama:clocktype"];

            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<TamagotchiService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TamagotchiRepository>()
                .As<IRepository<Tamagotchi>>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TamagotchiContext>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AssignableTo<ISpelregel>()
                .As<ISpelregel>()
                .InstancePerLifetimeScope();

            if(clocktype == "minutes")
            {
                builder.RegisterType<GameClockMin>()
                .As<IGameClock>()
                .InstancePerLifetimeScope();
            }
            else
            {
                builder.RegisterType<GameClockHours>()
                .As<IGameClock>()
                .InstancePerLifetimeScope();
            }

            builder.RegisterType<SpelregelEngine>()
                .InstancePerLifetimeScope();
            
            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

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