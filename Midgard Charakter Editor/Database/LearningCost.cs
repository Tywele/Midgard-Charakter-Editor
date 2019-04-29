namespace Midgard_Charakter_Editor.Database
{
    public class LearningCost
	{
		public int Id { get; set; }
		public int Value { get; set; }
		public int Easy { get; set; }
		public int Normal { get; set; }
		public int Hard { get; set; }
		public int VeryHard { get; set; }

        public int CategoryId { get; set; }
		public Category Category { get; set; }

        public LearningCost(int id, int value, int easy, int normal, int hard, int veryHard, int categoryId)
        {
            Id = id;
            Value = value;
            Easy = easy;
            Normal = normal;
            Hard = hard;
            VeryHard = veryHard;
            CategoryId = categoryId;
        }

        public LearningCost(int id, int value, int easy, int normal, int hard, int categoryId)
        {
            Id = id;
            Value = value;
            Easy = easy;
            Normal = normal;
            Hard = hard;
            VeryHard = -1;
            CategoryId = categoryId;
        }
	}
}
