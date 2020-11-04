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
            // var builder = new ContainerBuilder();

            this.Log().Info($"Registering Types");
            Locator.CurrentMutable.Register(() => new Seeder(), typeof(ISeeder));
            Locator.CurrentMutable.Register(() => new MidgardContext(), typeof(IMidgardContext));

            this.Log().Info($"Registering ViewModels");
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
            // builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(t =>
            //     t.FullName != null && t.FullName.StartsWith("MidgardCharakterEditor.ViewModel.",
            //         StringComparison.InvariantCulture)).AsSelf();

            // this.Log().Info($"Registering Views");
            // Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
            // builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(t =>
            //            t.FullName != null && t.FullName.StartsWith("MidgardCharakterEditor.View.",
            //                StringComparison.InvariantCulture))
            //        .AsImplementedInterfaces();

            // this.Log().Info($"Configuring Autofac as Service Locator");
            // var autofacResolver = builder.UseAutofacDependencyResolver();
            // builder.RegisterInstance(autofacResolver);
            // autofacResolver.InitializeReactiveUI();
            //
            // this.Log().Info($"Building Autofac container");
            // var container = builder.Build();
            //
            // this.Log().Info($"Creating Autofac lifetime scope");
            // var autofacDependencyResolver = container.Resolve<AutofacDependencyResolver>();
            // autofacDependencyResolver.SetLifetimeScope(container);
        }
    }
}