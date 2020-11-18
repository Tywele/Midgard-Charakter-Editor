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
                this.Bind(ViewModel, viewModel => viewModel.Character.Level, view => view.LevelTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.SocialClass, view => view.SocialClassesComboBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Origin, view => view.LandsComboBox.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Age, view => view.AgeTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Size, view => view.SizeTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Weight, view => view.WeightTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Build, view => view.BuildTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Handedness, view => view.HandednessTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Religion, view => view.ReligionTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.SmilingFate, view => view.SmilingFateTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.DivineMercy, view => view.DivineMercyTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Story, view => view.StoryTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Strength, view => view.StrengthTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Dexterity, view => view.DexterityTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Agility, view => view.AgilityTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Constitution, view => view.ConstitutionTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Intelligence, view => view.IntelligenceTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.MagicTalent, view => view.MagicTalentTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Appearance, view => view.AppearanceTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Charisma, view => view.CharismaTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Movement, view => view.MovementTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Health, view => view.HealthTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Stamina, view => view.StaminaTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel, viewModel => viewModel.Character.Defense, view => view.DefenseTextBox.Text)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, viewModel => viewModel.Character.CharacterHasLanguages,
                    view => view.LanguageListView.ItemsSource).DisposeWith(disposables);
                this.BindCommand(ViewModel!, viewModel => viewModel.OpenLanguageSelectionCommand,
                    view => view.AddLanguageButton).DisposeWith(disposables);
            });
        }
    }
}