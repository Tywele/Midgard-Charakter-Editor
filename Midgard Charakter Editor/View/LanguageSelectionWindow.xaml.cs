using System.Reactive.Disposables;
using System.Windows;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
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
            });
        }
    }
}