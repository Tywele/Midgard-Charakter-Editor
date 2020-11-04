using System.Reactive;
using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class MainViewModel : ReactiveObject, IScreen
    {
        private readonly IMidgardContext                           _context;
        public           RoutingState                              Router { get; }
        public           ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; set; }
        public           ReactiveCommand<Unit, Unit>               GoBack { get; set; }

        public MainViewModel()
        {
            // _context = Locator.Current.GetService<IMidgardContext>();
            Router = new RoutingState();
            GoNext = ReactiveCommand.CreateFromObservable(() =>
                Router.Navigate.Execute(new FirstViewModel()));
            GoBack = Router.NavigateBack;
        }
    }
}