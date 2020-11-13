using System;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Controls;
using System.Windows.Markup;
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
                this.Bind(ViewModel, viewModel => viewModel.SpellNameLabel, view => view.SpellName.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.TestLabel, view => view.TestLabel.Text)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel!, viewModel => viewModel.SetTestLabelCommand, view => view.TestButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel, viewModel => viewModel.SetSpellNameCommand, view => view.SpellSearchBox, viewModel => viewModel.SpellSearchTerm, nameof(SpellSearchBox.TextChanged))
                    .DisposeWith(disposables);

                // SpellSearchBox.Events().KeyUp.Select(args => Unit.Default)
                //           .InvokeCommand(this, x => x.ViewModel.SetSpellNameCommand).DisposeWith(disposables);
            });
        }
    }
}