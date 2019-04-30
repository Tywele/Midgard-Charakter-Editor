using Midgard_Charakter_Editor.Database;
using System.Linq;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using System.Text;

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

            }
            var path = @"C:\Liste der Zauber - M5 - Zauberlieder.csv";
            StringBuilder stringBuilder = new StringBuilder();
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                var counter = 287;

                while (!csvParser.EndOfData)
                {
                    string line = string.Empty, line2 = string.Empty, line3 = string.Empty;
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    line = $"modelBuilder.Entity<Spell>().HasData(new Spell({counter}, \"{fields[0]}\", \"{fields[1]}\", {fields[11]}, \"{fields[12]}\", \"{fields[13]}\", \"{fields[4]}\", \"{fields[5]}\", \"{fields[6]}\", \"{fields[7]}\", \"{fields[8]}\", \"{fields[9]}\", \"{fields[10]}\", \"{fields[14]}\", {fields[2]}, {fields[3]}, {fields[15]}));";
                    counter++;

                    //if (fields[7] != "-")
                    //{
                    //    line2 = $"modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory({counter}, {fields[5]}, {fields[7]}));";
                    //    counter++;
                    //}

                    //if (fields[8] != "-")
                    //{
                    //    line3 = $"modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory({counter}, {fields[5]}, {fields[8]}));";
                    //    counter++;
                    //}

                    if (!string.IsNullOrEmpty(line)) System.Console.WriteLine(line);
                    //if (!string.IsNullOrEmpty(line2)) System.Console.WriteLine(line2);
                    //if (!string.IsNullOrEmpty(line3)) System.Console.WriteLine(line3);
                }
            }
        }
	}
}
