using MidgardCharakterEditor.Database;
using ReactiveUI;

namespace MidgardCharakterEditor
{
    public class MainViewModel : ReactiveObject
    {
        private string _text;

        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref this._text, value);
        }
        
        public MainViewModel(IMidgardContext context)
        {
            Text = "Hello World";
        }
    }
}