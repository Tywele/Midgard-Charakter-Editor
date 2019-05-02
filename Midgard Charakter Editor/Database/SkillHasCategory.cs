namespace Midgard_Charakter_Editor.Database
{
    public class SkillHasCategory
    {
        public int Id { get; set; }
        public int Difficulty { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public SkillHasCategory(int id, int difficulty, int skillId, int categoryId)
        {
            Id = id;
            Difficulty = difficulty;
            SkillId = skillId;
            CategoryId = categoryId;
        } 
    }
}