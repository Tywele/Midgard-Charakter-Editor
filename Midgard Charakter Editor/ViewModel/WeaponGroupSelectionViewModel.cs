using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using Microsoft.EntityFrameworkCore;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class WeaponGroupSelectionViewModel : ReactiveObject, IDialogWindow
    {
        private readonly IMidgardContext _context;

        [Reactive] public List<Skill> WeaponGroups        { get; set; }
        [Reactive] public Skill       SelectedWeaponGroup { get; set; }
        [Reactive] public bool?        DialogResult        { get; set; }

        public ReactiveCommand<Unit, Unit> Confirm { get; set; }

        public WeaponGroupSelectionViewModel(IMidgardContext context = null)
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            WeaponGroups = _context.Skills.AsEnumerable().Where(s => s.Field.EndsWith("waffe", StringComparison.InvariantCulture)).ToList();

            Confirm = ReactiveCommand.Create(() => { DialogResult = true; });
        }
    }
}