namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Kosten der verschiedenen Kategorien für alle Klassen (siehe Seite 157 im Kodex).
    /// </summary>
    public class ClassCost
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ClassCost(int id, int value, int classId, int categoryId)
        {
            Id = id;
            Value = value;
            ClassId = classId;
            CategoryId = categoryId;
        }
    }
}
