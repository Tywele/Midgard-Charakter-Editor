using System.Reflection;
using System.Windows;
using Splat;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application, IEnableLogger
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.Log().Info($"Starting up Application: {Assembly.GetExecutingAssembly().FullName}");

            base.OnStartup(e);
            new Bootstrapper().Startup();
        }
    }
}