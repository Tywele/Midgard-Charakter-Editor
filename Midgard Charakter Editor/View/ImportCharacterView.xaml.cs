using System.Reactive.Disposables;
using System.Windows.Controls;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
{
    public partial class ImportCharacterView : ReactiveUserControl<ImportCharacterViewModel>
    {
        public ImportCharacterView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel, viewModel => viewModel.Character.Name, view => view.NameTextBox.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}