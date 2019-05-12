using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Database
{
	public class CharacterHasSkill
	{
		public int Id { get; set; }
		public Character Character { get; set; }
		public Skill Skill { get; set; }
		public int Value { get; set; }
	}
}
