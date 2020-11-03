using System.Reflection;
using Autofac;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using Splat;
using Splat.Autofac;

namespace MidgardCharakterEditor
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Bootstrapper : IEnableLogger
    {
        public static void Startup()
        {
            var builder = new ContainerBuilder();

            // Registrations
            builder.RegisterType<Seeder>().As<ISeeder>();
            builder.RegisterType<MidgardContext>().As<IMidgardContext>();

            builder.RegisterType<MainWindow>().As<IViewFor<MainViewModel>>();
            builder.RegisterType<MainViewModel>().AsSelf();

            var autofacResolver = builder.UseAutofacDependencyResolver();
            builder.RegisterInstance(autofacResolver);
            autofacResolver.InitializeReactiveUI();

            var container = builder.Build();

            var autofacDependencyResolver = container.Resolve<AutofacDependencyResolver>();
            autofacDependencyResolver.SetLifetimeScope(container);
        }
    }
}