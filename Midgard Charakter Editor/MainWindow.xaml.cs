using Autofac;
using MidgardCharakterEditor.Database;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            using (ILifetimeScope scope = AppWide.LifetimeScope.BeginLifetimeScope())
            {
                IMidgardContext context = scope.Resolve<IMidgardContext>();
            }
        }
    }
}
