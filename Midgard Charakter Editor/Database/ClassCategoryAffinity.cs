namespace Midgard_Charakter_Editor.Database
{
    public class ClassCategoryAffinity
	{
		public int Id { get; set; }
		public Class Class { get; set; }
		public Category Category { get; set; }
		public int Value { get; set; }
	}
}
