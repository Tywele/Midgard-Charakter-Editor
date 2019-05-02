using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class Weapon
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string BluntDamage { get; set; }
        public string StabDamage { get; set; }
        public string StormDamage { get; set; }
        public string Protection { get; set; }
		public int MinStrength { get; set; }
		public int MinDexterity { get; set; }
        public int MinAgility { get; set; }
		public string Description { get; set; }
        public string Note { get; set; }
        public string Range { get; set; }

		public virtual ICollection<CharacterHasWeapon> CharacterHasWeapons { get; set; }

        public Weapon(int id, string name, string bluntDamage, string stabDamage, 
            string stormDamage, string protection, int minStrength, 
            int minDexterity, int minAgility, string note, string range)
        {
            Id = id;
            Name = name;
            BluntDamage = bluntDamage;
            StabDamage = stabDamage;
            StormDamage = stormDamage;
            Protection = protection;
            MinStrength = minStrength;
            MinDexterity = minDexterity;
            MinAgility = minAgility;
            Note = note;
            Range = range;

            CharacterHasWeapons = new HashSet<CharacterHasWeapon>();
        }
	}
}
