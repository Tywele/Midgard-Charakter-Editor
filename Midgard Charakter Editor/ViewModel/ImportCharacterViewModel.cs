using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Windows.Controls.Primitives;
using DynamicData;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.Extensions;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Abstractions;
using Splat;
using ValidationContext = ReactiveUI.Validation.Contexts.ValidationContext;

namespace MidgardCharakterEditor.ViewModel
{
    public class ImportCharacterViewModel : ViewModelBase, IValidatableViewModel
    {
        private readonly IMidgardContext _context;

        [Reactive] public Character Character { get; set; }

        public ValidationContext ValidationContext { get; }
        public List<Race>        Races             { get; set; }
        public List<Class>       Classes           { get; set; }
        public List<Land>        Lands             { get; set; }
        public List<SocialClass> SocialClasses     { get; set; }

        public ObservableCollection<CharacterHasLanguage> CharacterHasLanguages { get; set; } =
            new ObservableCollection<CharacterHasLanguage>();

        public ObservableCollection<CharacterHasWeapon> CharacterHasWeapons { get; set; } =
            new ObservableCollection<CharacterHasWeapon>();

        public ObservableCollection<CharacterHasSkill> CharacterHasSkills { get; set; } =
            new ObservableCollection<CharacterHasSkill>();

        [Reactive] public CharacterHasLanguage SelectedLanguage { get; set; }
        [Reactive] public CharacterHasWeapon   SelectedWeapon   { get; set; }
        [Reactive] public CharacterHasSkill    SelectedSkill    { get; set; }

        public ReactiveCommand<Unit, Unit> OpenLanguageSelection { get; }
        public ReactiveCommand<int, Unit>  RemoveLanguage        { get; }
        public Interaction<Unit, Language> AddLanguageFromDialog { get; }

        public ReactiveCommand<Unit, Unit> OpenWeaponSelection { get; }
        public ReactiveCommand<int, Unit>  RemoveWeapon        { get; set; }
        public Interaction<Unit, Weapon>   AddWeaponFromDialog { get; set; }

        public ReactiveCommand<Unit, Unit> OpenWeaponGroupSelection { get; set; }
        public ReactiveCommand<int, Unit>  RemoveWeaponGroup        { get; set; }
        public Interaction<Unit, Skill>    AddWeaponGroupFromDialog { get; set; }

        public ImportCharacterViewModel(IMidgardContext context = null) : base("Import")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Character     = new Character();
            Races         = _context.Races.ToList();
            Classes       = _context.Classes.ToList();
            Lands         = _context.Lands.ToList();
            SocialClasses = _context.SocialClasses.ToList();

            OpenLanguageSelection = ReactiveCommand.Create(OpenLanguageSelectionImpl);
            RemoveLanguage        = ReactiveCommand.Create<int>(id => CharacterHasLanguages.Remove(SelectedLanguage));

            OpenWeaponSelection = ReactiveCommand.Create(OpenWeaponSelectionImpl);
            RemoveWeapon        = ReactiveCommand.Create<int>(id => CharacterHasWeapons.Remove(SelectedWeapon));
            
            OpenWeaponGroupSelection = ReactiveCommand.Create(OpenWeaponGroupSelectionImpl);
            RemoveWeaponGroup = ReactiveCommand.Create<int>(id => CharacterHasSkills.Remove(SelectedSkill));

            // this.ValidationRule(
            //     viewModel => viewModel.Character.Level,
            //     level => level > 0, 
            //     "Grad muss eine Zahl sein");

            AddLanguageFromDialog = new Interaction<Unit, Language>();
            AddLanguageFromDialog.RegisterHandler(SelectLanguageHandler);

            AddWeaponFromDialog = new Interaction<Unit, Weapon>();
            AddWeaponFromDialog.RegisterHandler(SelectWeaponHandler);
            
            AddWeaponGroupFromDialog = new Interaction<Unit, Skill>();
            AddWeaponGroupFromDialog.RegisterHandler(SelectWeaponGroupHandler);
        }

        private void OpenWeaponGroupSelectionImpl()
        {
            AddWeaponGroupFromDialog.Handle(Unit.Default).Where(weaponGroup => weaponGroup != null).Subscribe(weaponGroup =>
            {
                CharacterHasSkills.Add(new CharacterHasSkill()
                {
                    Character = Character,
                    Skill    = weaponGroup
                });
            });
        }

        private void SelectWeaponGroupHandler(InteractionContext<Unit, Skill> interaction)
        {
            var viewModel = new WeaponGroupSelectionViewModel(_context);
            var view      = viewModel.GetView();
            var confirm   = view.ShowDialog();

            if (confirm != null && confirm.Value)
                interaction.SetOutput(viewModel.SelectedWeaponGroup);
            else
                interaction.SetOutput(null);
        }

        private void SelectWeaponHandler(InteractionContext<Unit, Weapon> interaction)
        {
            var viewModel = new WeaponSelectionViewModel(_context);
            var view      = viewModel.GetView();
            var confirm   = view.ShowDialog();

            if (confirm != null && confirm.Value)
                interaction.SetOutput(viewModel.SelectedWeapon);
            else
                interaction.SetOutput(null);
        }

        private void OpenWeaponSelectionImpl()
        {
            AddWeaponFromDialog.Handle(Unit.Default).Where(weapon => weapon != null).Subscribe(weapon =>
            {
                CharacterHasWeapons.Add(new CharacterHasWeapon()
                {
                    Character = Character,
                    Weapon    = weapon
                });
            });
        }

        private void OpenLanguageSelectionImpl()
        {
            AddLanguageFromDialog.Handle(Unit.Default).Where(language => language != null).Subscribe(language =>
            {
                CharacterHasLanguages.Add(new CharacterHasLanguage()
                {
                    Character = Character,
                    Language  = language
                });
            });
        }

        private void SelectLanguageHandler(InteractionContext<Unit, Language> interaction)
        {
            var viewModel = new LanguageSelectionViewModel(_context);
            var view      = viewModel.GetView();
            var confirm   = view.ShowDialog();

            if (confirm != null && confirm.Value)
                interaction.SetOutput(viewModel.SelectedLanguage);
            else
                interaction.SetOutput(null);
        }
    }
}