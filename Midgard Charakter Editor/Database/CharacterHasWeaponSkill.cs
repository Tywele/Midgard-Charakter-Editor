﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class CharacterHasWeaponSkill
	{
		public int Id { get; set; }
		public Character Character { get; set; }
		public WeaponSkill WeaponSkill { get; set; }
		public int Value { get; set; }
		public bool Specialization { get; set; }
	}
}
