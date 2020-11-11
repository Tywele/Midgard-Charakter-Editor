using System.Reactive.Disposables;
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
                this.OneWayBind(ViewModel, viewModel => viewModel.SpellSearchResultList, view => view.SpellListView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SpellSearchTerm, view => view.SpellSearchBox.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}