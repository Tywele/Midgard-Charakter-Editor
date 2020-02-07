namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Lernkosten der Fertigkeiten (siehe Seite 158ff im Kodex).
    /// </summary>
    public class SkillLearningCost
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Difficulty { get; set; }
        public int Cost { get; set; }

        public SkillLearningCost(int id, int categoryId, int difficulty, int cost)
        {
            Id = id;
            CategoryId = categoryId;
            Difficulty = difficulty;
            Cost = cost;
        }
    }
}