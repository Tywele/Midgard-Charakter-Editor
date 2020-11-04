using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;
using Splat;

namespace MidgardCharakterEditor.View
{
    public partial class MainWindow : ReactiveWindow<MainViewModel>, IEnableLogger
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();

            this.WhenActivated(disposable =>
            {
                // Bind the view model router to RoutedViewHost.Router property.
                this.OneWayBind(ViewModel, x => x.Router, x => x.RoutedViewHost.Router)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel!, x => x.GoNext, x => x.GoNextButton)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, x => x.GoBack, x => x.GoBackButton)
                    .DisposeWith(disposable);
            });

            var context = Locator.Current.GetService<IMidgardContext>();
            var output  = $"{context.Lands.Count()}";
            this.Log().Info(output);
        }
    }
}