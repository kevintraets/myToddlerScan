using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Repository;
using ToddlerScanV2.Services.Data;
using ToddlerScanV2.Services.General;
using ToddlerScanV2.ViewModels;

namespace ToddlerScanV2.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<AllToddlersViewModel>();
            builder.RegisterType<ChangeGradeViewModel>();

            //Services
            builder.RegisterType<ToddlerService>().As<IToddlerService>();

            //Services - general
            builder.RegisterType<NavigationService>().As<INavigationService>();

            //General
            builder.RegisterType<GenericRepository>().As<IGenericRepository>();

            _container = builder.Build();

        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
