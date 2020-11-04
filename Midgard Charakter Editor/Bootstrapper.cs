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
            this.Log().Info($"Initializing Bootstrapper");

            this.Log().Info($"Registering Types");
            Locator.CurrentMutable.Register(() => new Seeder(), typeof(ISeeder));
            Locator.CurrentMutable.Register(() => new MidgardContext(), typeof(IMidgardContext));

            this.Log().Info($"Registering Views and ViewModels");
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
        }
    }
}