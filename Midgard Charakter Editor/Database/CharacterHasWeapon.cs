namespace MidgardCharakterEditor.Database
{
    public class CharacterHasWeapon
	{
		public int Id { get; set; }

        public int CharacterId { get;set; }
		public Character Character { get; set; }

        public int WeaponId { get; set; }
		public Weapon Weapon { get; set; }

		public int Value { get; set; }
		public bool Specialization { get; set; }
	}
}
