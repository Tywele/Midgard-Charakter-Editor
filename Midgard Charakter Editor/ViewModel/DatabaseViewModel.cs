using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Security.Cryptography;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class DatabaseViewModel : ViewModelBase
    {
        private readonly IMidgardContext _context;

        public List<Spell> SpellList { get; set; }

        [Reactive] public string SpellSearchTerm    { get; set; }
        [Reactive] public string SpellNameLabel     { get; set; }
        [Reactive] public string TestLabel          { get; set; }

        private readonly ObservableAsPropertyHelper<IEnumerable<Spell>> _spellSearchResultList;
        public           IEnumerable<Spell> SpellSearchResultList => _spellSearchResultList.Value;

        public ReactiveCommand<string, Unit> SetSpellNameCommand { get; }
        public ReactiveCommand<Unit, Unit>   SetTestLabelCommand { get; }

        public DatabaseViewModel(IMidgardContext context = null) : base("Database")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            SpellList = _context.Spells.ToList();

            SpellNameLabel = "This is a spell name";

            _spellSearchResultList = this.WhenAnyValue(viewModel => viewModel.SpellSearchTerm)
                                         .Throttle(TimeSpan.FromSeconds(0.8))
                                         .Select(searchTerm => searchTerm?.ToUpperInvariant().Trim())
                                         .DistinctUntilChanged()
                                         .Where(searchTerm => !string.IsNullOrWhiteSpace(searchTerm))
                                         .Select(searchTerm =>
                                             SpellList.Where(spell =>
                                                 spell.Name.ToUpperInvariant().Contains(searchTerm)).ToList())
                                         .ObserveOn(RxApp.MainThreadScheduler)
                                         .ToProperty(this, viewModel => viewModel.SpellSearchResultList);

            SetSpellNameCommand = ReactiveCommand.Create<string>(SetSpellName);
            SetTestLabelCommand = ReactiveCommand.Create(SetTestLabel);
        }

        private void SetTestLabel()
        {
            TestLabel = "BindCommand fired!";
        }

        private void SetSpellName(string text)
        {
            SpellNameLabel = text;
        }
    }
}