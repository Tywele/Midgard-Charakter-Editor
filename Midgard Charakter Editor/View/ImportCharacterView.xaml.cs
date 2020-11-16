using System.Reactive.Disposables;
using System.Windows.Controls;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
{
    public partial class ImportCharacterView : ReactiveUserControl<ImportCharacterViewModel>
    {
        public ImportCharacterView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, viewModel => viewModel.Classes, view => view.ClassComboBox.ItemsSource)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.Races, view => view.RaceComboBox.ItemsSource)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.Lands, view => view.LandsComboBox.ItemsSource)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.SocialClasses, view => view.SocialClassesComboBox.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Name, view => view.NameTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Class, view => view.ClassComboBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Race, view => view.RaceComboBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.SocialClass, view => view.SocialClassesComboBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Origin, view => view.LandsComboBox.SelectedItem)
                    .DisposeWith(disposables);
            });
        }
    }
}