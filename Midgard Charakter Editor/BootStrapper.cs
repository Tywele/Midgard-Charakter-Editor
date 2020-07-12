using Autofac;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.Utilities;

namespace MidgardCharakterEditor
{
    public static class BootStrapper
    {
        public static void Start()
        {
            if (AppWide.LifetimeScope != null) return;

            var builder = new ContainerBuilder();

            builder.RegisterType<Seeder>().As<ISeeder>();
            builder.RegisterType<MidgardContext>().As<IMidgardContext>();
            //builder.RegisterGeneric < typeof(LogManager.GetCurrentClassLogger()))>.As<ILogger>();
            builder.RegisterType<Die>().As<IDie>();

            AppWide.LifetimeScope = builder.Build();
        }
    }
}
