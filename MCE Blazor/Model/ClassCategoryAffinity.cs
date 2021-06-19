namespace MCE.Model
{
    /// <summary>
    /// Die Lerneinheiten der Klassen in den verschiedenen Kategorien bei Spielbeginn (siehe Seite 38 im Kodex).
    /// </summary>
    public class ClassCategoryAffinity
    {
        public int Id { get; set; }

        public int   ClassId { get; set; }
        public Class Class   { get; set; }

        public int      CategoryId { get; set; }
        public Category Category   { get; set; }

        public int?     SecondaryCategoryId { get; set; }
        public Category SecondaryCategory   { get; set; }

        public int Value { get; set; }

        public ClassCategoryAffinity(int id, int classId, int value, int categoryId, int? secondaryCategoryId = null)
        {
            Id                  = id;
            ClassId             = classId;
            Value               = value;
            CategoryId          = categoryId;
            SecondaryCategoryId = secondaryCategoryId;
        }
    }
}