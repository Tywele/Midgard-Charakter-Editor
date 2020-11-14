using System.Reactive.Disposables;
using MidgardCharakterEditor.Database;
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
                        view => view.SpellListBox.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SpellSearchTerm, view => view.SpellSearchBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedSpell, view => view.SpellListBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedSpell.Name, view => view.SpellName.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedSpell.Type, view => view.SpellType.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedSpell.Process.Name, view => view.SpellProcess.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}