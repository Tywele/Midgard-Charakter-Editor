﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
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

        [Reactive] public CharacterHasLanguage SelectedLanguage { get; set; }

        public ReactiveCommand<Unit, Unit> OpenLanguageSelection { get; }
        public ReactiveCommand<int, Unit>  RemoveLanguage        { get; }
        public Interaction<Unit, Language> AddLanguageFromDialog { get; }

        public ImportCharacterViewModel(IMidgardContext context = null) : base("Import")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Character     = new Character();
            Races         = _context.Races.ToList();
            Classes       = _context.Classes.ToList();
            Lands         = _context.Lands.ToList();
            SocialClasses = _context.SocialClasses.ToList();

            OpenLanguageSelection = ReactiveCommand.Create(OpenLanguageSelectionImpl);
            RemoveLanguage = ReactiveCommand.Create<int>(id =>
            {
                CharacterHasLanguages.Remove(SelectedLanguage);
            });

            // this.ValidationRule(
            //     viewModel => viewModel.Character.Level,
            //     level => level > 0, 
            //     "Grad muss eine Zahl sein");

            AddLanguageFromDialog = new Interaction<Unit, Language>();
            AddLanguageFromDialog.RegisterHandler(SelectLanguageHandler);
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