using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View.Modals
{
    public partial class LanguageSelectionWindow : ReactiveWindow<LanguageSelectionViewModel>
    {
        public LanguageSelectionWindow()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, viewModel => viewModel.Languages, view => view.LanguageListView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedLanguage,
                    view => view.LanguageListView.SelectedItem).DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.DialogResult, view => view.DialogResult).DisposeWith(disposables);
                this.BindCommand(ViewModel!, 
                    viewModel => viewModel.Confirm,
                    view => view.SelectLanguageButton)
                    .DisposeWith(disposables);
            });
        }
    }
}