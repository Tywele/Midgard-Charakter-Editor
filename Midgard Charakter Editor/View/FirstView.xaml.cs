using System.Reactive.Disposables;
using System.Windows.Controls;
using MidgardCharakterEditor.ViewModel;
using ReactiveUI;

namespace MidgardCharakterEditor.View
{
    public partial class FirstView : ReactiveUserControl<FirstViewModel>
    {
        public FirstView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.PathTextBlock.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}