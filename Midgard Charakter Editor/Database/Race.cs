namespace Midgard_Charakter_Editor.Database
{
	public class Race
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ResistanceBonus { get; set; }
		public int HealthBonus { get; set; }

        public Race(int id, string name, int resistanceBonus, int healthBonus)
        {
            Id = id;
            Name = name;
            ResistanceBonus = resistanceBonus;
            HealthBonus = healthBonus;
        }
	}
}