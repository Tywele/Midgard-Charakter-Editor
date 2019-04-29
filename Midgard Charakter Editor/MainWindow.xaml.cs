using Midgard_Charakter_Editor.Database;
using System.Linq;
using System.Windows;

namespace Midgard_Charakter_Editor
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			using (var context = new MidgardContext())
			{
                //context.Classes.Add(new Class { Name = "Test", Abbreviation = "tst" });
                //context.SaveChanges();
			}
		}
	}
}
