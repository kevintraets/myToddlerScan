using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using uwpSide.Interfaces;
using uwpSide.Services;
using uwpSide.ViewModels;

namespace uwpSide.Bootstrap
{
    public static class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NavViewModel>();
            builder.RegisterType<TripViewModel>();
            builder.RegisterType<ScanQRCodeViewModel>();
            builder.RegisterType<PlanTripViewModel>();
            builder.RegisterType<MockAPI.MockAPI>();

            builder.RegisterType<TripService>().As<ITripService>();
            builder.RegisterType<ToddlerService>().As<IToddlerService>();
            builder.RegisterType<TeacherService>().As<ITeacherService>();

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
