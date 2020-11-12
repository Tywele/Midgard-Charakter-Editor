using System.Net.Mime;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Controls;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
{
    public partial class DatabaseView : ReactiveUserControl<DatabaseViewModel>
    {
        public DatabaseView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, viewModel => viewModel.SpellSearchResultList,
                        view => view.SpellListView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SpellSearchTerm, view => view.SpellSearchBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Label, view => view.SpellName.Text)
                    .DisposeWith(disposables);

                TestButton.Events().MouseDoubleClick.Select(args => Unit.Default)
                              .InvokeCommand(this, x => x.ViewModel.SetLabelCommand).DisposeWith(disposables);
            });
        }
    }
}