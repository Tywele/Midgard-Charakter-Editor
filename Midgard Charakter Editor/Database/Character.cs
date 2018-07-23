using System.Collections.Generic;

namespace Midgard_Charakter_Editor.Database
{
	public class Character
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Race Race { get; set; }
		public Class Class { get; set; }
		public string Handedness { get; set; }
		public string Build { get; set; }
		public int Age { get; set; }
		public string Origin { get; set; }
		public string Religion { get; set; }
		public string Story { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Agility { get; set; }
		public int Constitution { get; set; }
		public int Intelligence { get; set; }
		public int MagicTalent { get; set; }
		public int Health { get; set; }
		public int Stamina { get; set; }
		public int Appearance { get; set; }
		public int Charisma { get; set; }
		public int Defense { get; set; }
		public int Resistance { get; set; }
		public int Movement { get; set; }
		public int Xp { get; set; }
		public int Level { get; set; }
		public int OpenXp { get; set; }

		public virtual ICollection<CharacterHasSpell> CharacterHasSpells { get; set; }
		public virtual ICollection<CharacterHasSkill> CharacterHasSkills { get; set; }
		public virtual ICollection<CharacterHasWeaponSkill> CharacterHasWeaponSkills { get; set; }
	}
}
