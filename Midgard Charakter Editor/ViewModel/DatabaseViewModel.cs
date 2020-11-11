using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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

        [Reactive] public string SpellSearchTerm { get; set; }

        private readonly ObservableAsPropertyHelper<IEnumerable<Spell>> _searchResultList;
        public           IEnumerable<Spell> SpellSearchResultList => _searchResultList.Value;

        public DatabaseViewModel(IMidgardContext context = null) : base("Database")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            SpellList = _context.Spells.ToList();

            _searchResultList = this.WhenAnyValue(viewModel => viewModel.SpellSearchTerm)
                                    .Throttle(TimeSpan.FromSeconds(0.8))
                                    .Select(searchTerm => searchTerm?.Trim())
                                    .DistinctUntilChanged()
                                    .Where(searchTerm => !string.IsNullOrWhiteSpace(searchTerm))
                                    .Select(searchTerm =>
                                        SpellList.Where(spell => spell.Name.Contains(searchTerm)).ToList())
                                    .ObserveOn(RxApp.MainThreadScheduler)
                                    .ToProperty(this, viewModel => viewModel.SpellSearchResultList);
        }
    }
}