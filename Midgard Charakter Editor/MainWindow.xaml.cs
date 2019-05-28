using MidgardCharakterEditor.Database;
using System.Windows;
using Microsoft.VisualBasic.FileIO;

namespace MidgardCharakterEditor
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
            var path = @"C:\Liste der Länder.csv";
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                var counter = 0;

                while (!csvParser.EndOfData)
                {
                    string line = string.Empty, line2 = string.Empty, line3 = string.Empty;
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();


                    line = $"modelBuilder.Entity<Land>().HasData(new Land({fields[0]}, \"{fields[1]}\"));";
                    counter++;

                    //if (fields[6] != "-")
                    //{
                    //    line2 = $"modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory({counter}, {fields[10]}, {fields[8]}, {fields[13]}));";
                    //    counter++;
                    //}

                    //if (fields[7] != "-")
                    //{
                    //    line3 = $"modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory({counter}, {fields[11]}, {fields[8]}, {fields[14]}));";
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
