using MidgardCharakterEditor.Database;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new MidgardContext())
            {

            }
        }
    }
}
