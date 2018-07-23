using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<SkillHasCategory> SkillHasCategories { get; set; }
	}
}
