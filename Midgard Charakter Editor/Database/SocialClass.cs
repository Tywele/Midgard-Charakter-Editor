namespace MidgardCharakterEditor.Database
{
    public class SocialClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Kategorie für die es bei der Erstellung des Charakters einen Bonus von 2 LE gibt.
        public int BonusCategoryId { get; set; }
        public Category BonusCategory { get; set; }

        public SocialClass(int id, string name, int bonusCategoryId)
        {
            Id = id;
            Name = name;
            BonusCategoryId = bonusCategoryId;
        }
    }
}