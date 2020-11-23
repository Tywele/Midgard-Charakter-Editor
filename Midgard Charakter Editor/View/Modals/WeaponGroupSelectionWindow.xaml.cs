using System.Reactive.Disposables;
using System.Windows;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View.Modals
{
    public partial class WeaponGroupSelectionWindow : ReactiveWindow<WeaponGroupSelectionViewModel>
    {
        public WeaponGroupSelectionWindow()
        {
            InitializeComponent();
            
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, viewModel => viewModel.WeaponGroups, view => view.WeaponGroupListView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedWeaponGroup,
                    view => view.WeaponGroupListView.SelectedItem).DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.DialogResult, view => view.DialogResult).DisposeWith(disposables);
                this.BindCommand(ViewModel!, 
                        viewModel => viewModel.Confirm,
                        view => view.SelectWeaponGroupButton)
                    .DisposeWith(disposables);
            });
        }
    }
}