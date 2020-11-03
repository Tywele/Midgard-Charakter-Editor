using Autofac;
using MidgardCharakterEditor.Database;
using System;
using System.Linq;
using ReactiveUI;
using Splat;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IEnableLogger
    {
        public MainWindow()
        {
            InitializeComponent();

            var context = Locator.Current.GetService<IMidgardContext>();
            var output  = $"{context.Lands.Count()}";
            this.Log().Info(output);
        }
    }
}
