using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Windows;
using System.Windows.Forms;
using MidgardCharakterEditor.Database;
using MidgardCharakterEditor.View.Modals;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class LanguageSelectionViewModel : ReactiveObject
    {
        private readonly IMidgardContext _context;

        [Reactive] public List<Language>          Languages        { get; set; }
        [Reactive] public Language                SelectedLanguage { get; set; }
        // [Reactive] public LanguageSelectionWindow Window           { get; set; }

        // private readonly ObservableAsPropertyHelper<LanguageSelectionWindow> _window;
        // public           LanguageSelectionWindow Window => _window.Value;
        
        public ReactiveCommand<LanguageSelectionWindow, Unit> SelectLanguage { get; set; }

        public LanguageSelectionViewModel(IMidgardContext context = null)
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Languages = _context.Languages.ToList();

            SelectLanguage = ReactiveCommand.Create<LanguageSelectionWindow>(
                languageSelectionWindow => { languageSelectionWindow.DialogResult = true; });
        }
    }
}