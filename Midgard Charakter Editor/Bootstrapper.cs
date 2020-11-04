using System;
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
        public Bootstrapper()
        {
        }
        
        public void Startup()
        {
            this.Log().Info($"Initializing Bootstrapper");
            var builder = new ContainerBuilder();

            this.Log().Info($"Registering Types");
            builder.RegisterType<Seeder>().As<ISeeder>();
            builder.RegisterType<MidgardContext>().As<IMidgardContext>();


            this.Log().Info($"Registering ViewModels");
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(t =>
                t.FullName != null && t.FullName.StartsWith("MidgardCharakterEditor.ViewModel.",
                    StringComparison.InvariantCulture)).AsSelf();

            this.Log().Info($"Registering Views");
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(t =>
                       t.FullName != null && t.FullName.StartsWith("MidgardCharakterEditor.View.",
                           StringComparison.InvariantCulture))
                   .AsImplementedInterfaces();

            this.Log().Info($"Configuring Autofac as Service Locator");
            var autofacResolver = builder.UseAutofacDependencyResolver();
            builder.RegisterInstance(autofacResolver);
            autofacResolver.InitializeReactiveUI();

            this.Log().Info($"Building Autofac container");
            var container = builder.Build();

            this.Log().Info($"Creating Autofac lifetime scope");
            var autofacDependencyResolver = container.Resolve<AutofacDependencyResolver>();
            autofacDependencyResolver.SetLifetimeScope(container);
        }
    }
}