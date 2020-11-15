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

            this.WhenActivated(disposables =>
            {
                // Bind the view model router to RoutedViewHost.Router property.
                this.OneWayBind(ViewModel, x => x.Router, x => x.RoutedViewHost.Router)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.GoToDatabase, x => x.DatabaseButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.GoToCharacter, x => x.CharacterButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.GoToImport, x => x.ImportMenuItem)
                    .DisposeWith(disposables);
            });
        }
    }
}