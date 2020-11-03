using Autofac;
using MidgardCharakterEditor.Database;
using System;
using System.Linq;
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainViewModel>, IEnableLogger
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<MainViewModel>();
            
            this.WhenActivated(disposable =>
            {
                this.OneWayBind(this.ViewModel, x => x.Text, x => x.TheTextBlock.Text)
                    .DisposeWith(disposable);
            });
            
            var context = Locator.Current.GetService<IMidgardContext>();
            var output  = $"{context.Lands.Count()}";
            this.Log().Info(output);
        }
    }
}
