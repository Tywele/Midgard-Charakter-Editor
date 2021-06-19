namespace MCE.Model
{
    /// <summary>
    /// Welchen Kategorien die verschiedenen Fertigkeiten angehören (siehe Seite 158ff im Kodex).
    /// </summary>
    public class SkillHasCategory
    {
        public int Id         { get; set; }
        public int Difficulty { get; set; }

        public int   SkillId { get; set; }
        public Skill Skill   { get; set; }

        public int      CategoryId { get; set; }
        public Category Category   { get; set; }

        public SkillHasCategory(int id, int difficulty, int skillId, int categoryId)
        {
            Id         = id;
            Difficulty = difficulty;
            SkillId    = skillId;
            CategoryId = categoryId;
        }
    }
}