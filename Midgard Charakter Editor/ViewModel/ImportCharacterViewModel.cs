using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.View;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;
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

        public ReactiveCommand<Unit, Unit> OpenLanguageSelectionCommand { get; }

        public ImportCharacterViewModel(IMidgardContext context = null) : base("Import")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Character     = new Character();
            Races         = _context.Races.ToList();
            Classes       = _context.Classes.ToList();
            Lands         = _context.Lands.ToList();
            SocialClasses = _context.SocialClasses.ToList();

            OpenLanguageSelectionCommand = ReactiveCommand.Create(OpenLanguageSelection);

            // this.ValidationRule(
            //     viewModel => viewModel.Character.Level,
            //     level => level > 0, 
            //     "Grad muss eine Zahl sein");
        }

        private void OpenLanguageSelection()
        {
            var viewModel = new LanguageSelectionViewModel(_context);
            var view      = viewModel.GetView();
            view.Show();
        }
    }
}