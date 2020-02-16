using Autofac;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.Utilities;

namespace MidgardCharakterEditor
{
    public static class BootStrapper
    {
        public static ILifetimeScope _rootScope;

        public static void Start()
        {
            if (_rootScope != null) return;

            var builder = new ContainerBuilder();

            builder.RegisterType<MidgardContext>().As<IMidgardContext>();
            builder.RegisterType<Die>().As<IDie>();

            _rootScope = builder.Build();
        }
    }
}
