using MidgardCharakterEditor.Database;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using MahApps.Metro.Controls;

namespace MidgardCharakterEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
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
