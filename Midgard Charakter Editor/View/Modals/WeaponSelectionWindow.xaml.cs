using System.Reactive.Disposables;
using System.Windows;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View.Modals
{
    public partial class WeaponSelectionWindow : ReactiveWindow<WeaponSelectionViewModel>
    {
        public WeaponSelectionWindow()
        {
            InitializeComponent();
            
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, viewModel => viewModel.Weapons, view => view.WeaponListView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.SelectedWeapon,
                    view => view.WeaponListView.SelectedItem).DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.DialogResult, view => view.DialogResult).DisposeWith(disposables);
                this.BindCommand(ViewModel!, 
                        viewModel => viewModel.Confirm,
                        view => view.SelectWeaponButton)
                    .DisposeWith(disposables);
            });
        }
    }
}