using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class ImportCharacterViewModel : ViewModelBase
    {
        private readonly  IMidgardContext _context;
        
        [Reactive] public Character       Character { get; set; }

        public ImportCharacterViewModel(IMidgardContext context = null) : base("Import")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Character = new Character();
        }
    }
}