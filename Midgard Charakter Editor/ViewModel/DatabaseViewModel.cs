using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;
using DynamicData.Binding;
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

        [Reactive]             public List<Spell> Spells             { get; set; }
        [Reactive]             public string      SpellSearch        { get; set; }
        [ObservableAsProperty] public List<Spell> SpellSearchResults { get; }

        public DatabaseViewModel(IMidgardContext context = null) : base("Database")
        {
            _context = context ?? Locator.Current.GetService<IMidgardContext>();

            Spells = _context.Spells.ToList();

            // SpellSearchResults = this.WhenAnyValue(viewModel => viewModel.SpellSearch)
            //                          .Throttle(TimeSpan.FromSeconds(0.8))
            //                          .Select(search => search?.Trim())
            //                          .DistinctUntilChanged()
            //                          .Where(search => !string.IsNullOrWhiteSpace(search))
            //                          .SelectMany(search => Spells.Where(spell => spell.Name.Contains(search)))
            //                          .ObserveOn(RxApp.MainThreadScheduler)
            //                          .ToProperty(this, viewModel => viewModel.SpellSearchResults);
        }
    }
}