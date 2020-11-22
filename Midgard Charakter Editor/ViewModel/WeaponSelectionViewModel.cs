using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class WeaponSelectionViewModel : ReactiveObject, IDialogWindow
    {
        private readonly IMidgardContext _context;

        [Reactive] public List<Weapon> Weapons        { get; set; }
        [Reactive] public Weapon       SelectedWeapon { get; set; }
        [Reactive] public bool?        DialogResult   { get; set; }

        public ReactiveCommand<Unit, Unit> Confirm { get; set; }

        public WeaponSelectionViewModel(IMidgardContext context = null)
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Weapons = _context.Weapons.ToList();

            Confirm = ReactiveCommand.Create(() => { DialogResult = true; });
        }
    }
}