namespace MidgardCharakterEditor.Database
{
    // Lerneinheiten bei Spielbeginn? Kodex Seite 38
    public class ClassCategoryAffinity
	{
		public int Id { get; set; }
		public Class Class { get; set; }
		public Category Category { get; set; }
		public int Value { get; set; }
	}
}
