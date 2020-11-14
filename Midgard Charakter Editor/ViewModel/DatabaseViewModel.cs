using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class DatabaseViewModel : ViewModelBase
    {
        private readonly IMidgardContext _context;

        // public List<Spell> SpellList { get; set; }

        [Reactive] public string   SpellSearchTerm        { get; set; }
        [Reactive] public Spell    SelectedSpell          { get; set; }

        private readonly ObservableAsPropertyHelper<IEnumerable<Spell>> _spellSearchResultList;
        public           IEnumerable<Spell> SpellSearchResultList => _spellSearchResultList.Value;

        public DatabaseViewModel(IMidgardContext context = null) : base("Database")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            _spellSearchResultList = this.WhenAnyValue(viewModel => viewModel.SpellSearchTerm)
                                         .Throttle(TimeSpan.FromSeconds(0.8))
                                         .Select(searchTerm => searchTerm?.ToUpperInvariant().Trim())
                                         .DistinctUntilChanged()
                                         .SelectMany(GetSpellSearchResult)
                                         .ObserveOn(RxApp.MainThreadScheduler)
                                         .ToProperty(this, viewModel => viewModel.SpellSearchResultList);
        }

        private async Task<List<Spell>> GetSpellSearchResult(string searchTerm, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await _context.Spells.Include(spell => spell.Process).ToListAsync(token).ConfigureAwait(false);
            return _context.Spells.Include(spell => spell.Process).AsEnumerable()!.Where(spell =>
                spell.Name.ToUpperInvariant().Contains(searchTerm)).ToList();
        }
    }
}