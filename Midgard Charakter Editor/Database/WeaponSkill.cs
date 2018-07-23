using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class WeaponSkill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Damage { get; set; }
		public int MinStrength { get; set; }
		public int MinDexterity { get; set; }
		public int Protection { get; set; }
		public string Description { get; set; }

		public virtual ICollection<CharacterHasWeaponSkill> CharacterHasWeaponSkills { get; set; }
	}
}
