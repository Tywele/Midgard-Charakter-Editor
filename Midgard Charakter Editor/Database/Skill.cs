﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LeadingAttribute { get; set; }
		public string Field { get; set; }
		public int? Untrained { get; set; }
		public string Description { get; set; }

		public virtual ICollection<SkillHasCategory> SkillHasCategories { get; set; }
		public virtual ICollection<CharacterHasSkill> CharacterHasSkills { get; set; }

        public Skill(int id, string name, string leadingAttribute, string field, int? untrained = null)
        {
            Id = id;
            Name = name;
            LeadingAttribute = leadingAttribute;
            Field = field;
            Untrained = untrained;
        } 
	}
}
