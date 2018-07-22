using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class Skill
	{
		public int SkillID { get; set; }
		public string Name { get; set; }
		public string LeadingAttribute { get; set; }
		public string Field { get; set; }
		public int Untrained { get; set; }
		public string Description { get; set; }
		public Category Category { get; set; }
	}
}
