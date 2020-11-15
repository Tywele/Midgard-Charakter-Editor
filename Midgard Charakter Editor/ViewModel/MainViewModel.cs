using System.Reactive;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class MainViewModel : ReactiveObject, IScreen
    {
        public RoutingState                              Router        { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> GoToCharacter { get; set; }
        public ReactiveCommand<Unit, IRoutableViewModel> GoToSkills    { get; set; }
        public ReactiveCommand<Unit, IRoutableViewModel> GoToSpells    { get; set; }
        public ReactiveCommand<Unit, IRoutableViewModel> GoToDatabase  { get; set; }
        public ReactiveCommand<Unit, IRoutableViewModel> GoToImport  { get; set; }

        public MainViewModel()
        {
            Router = new RoutingState();
            GoToCharacter =
                ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new CharacterViewModel()));
            // GoToSkills = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new SkillsViewModel()));
            // GoToSpells = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new SpellsViewModel()));
            GoToDatabase =
                ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new DatabaseViewModel()));
            GoToImport =
                ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new ImportCharacterViewModel()));
        }
    }
}