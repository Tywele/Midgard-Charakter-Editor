namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Lerneinheiten bei Spielbeginn? Kodex Seite 38
    /// </summary>
    public class ClassCategoryAffinity
    {
        public int Id { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Value { get; set; }

        public ClassCategoryAffinity(int id, int classId, int categoryId, int value)
        {
            Id = id;
            ClassId = classId;
            CategoryId = categoryId;
            Value = value;
        }
    }
}
