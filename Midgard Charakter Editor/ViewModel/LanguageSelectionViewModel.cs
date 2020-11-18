using System.Collections.Generic;
using System.Linq;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class LanguageSelectionViewModel : ReactiveObject
    {
        private readonly  IMidgardContext _context;
        [Reactive] public List<Language>  Languages { get; set; }
        
        public LanguageSelectionViewModel(IMidgardContext context = null)
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Languages = _context.Languages.ToList();
        }
    }
}