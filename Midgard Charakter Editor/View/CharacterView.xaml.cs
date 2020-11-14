using System.Windows.Controls;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
{
    public partial class CharacterView : ReactiveUserControl<CharacterViewModel>
    {
        public CharacterView()
        {
            InitializeComponent();
        }
    }
}