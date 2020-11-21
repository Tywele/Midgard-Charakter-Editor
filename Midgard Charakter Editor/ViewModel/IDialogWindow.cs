using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace MidgardCharakterEditor.ViewModel
{
    public interface IDialogWindow
    {
        [Reactive] bool? DialogResult { get; set; }
        
        ReactiveCommand<Unit, Unit> Confirm { get; }
    }
}