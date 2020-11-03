namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Trainingskosten der Fertigkeiten (siehe Seite 158ff im Kodex)
    /// </summary>
    public class SkillTrainingCost
    {
        public int Id       { get; set; }
        public int Value    { get; set; }
        public int Easy     { get; set; }
        public int Normal   { get; set; }
        public int Hard     { get; set; }
        public int VeryHard { get; set; }

        public int      CategoryId { get; set; }
        public Category Category   { get; set; }

        public SkillTrainingCost(int id, int value, int easy, int normal, int hard, int veryHard, int categoryId)
        {
            Id         = id;
            Value      = value;
            Easy       = easy;
            Normal     = normal;
            Hard       = hard;
            VeryHard   = veryHard;
            CategoryId = categoryId;
        }

        public SkillTrainingCost(int id, int value, int easy, int normal, int hard, int categoryId)
        {
            Id         = id;
            Value      = value;
            Easy       = easy;
            Normal     = normal;
            Hard       = hard;
            VeryHard   = -1;
            CategoryId = categoryId;
        }
    }
}