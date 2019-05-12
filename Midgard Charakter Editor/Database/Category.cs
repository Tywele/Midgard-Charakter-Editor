using System.Collections.Generic;

namespace MidgardCharakterEditor.Database
{
    public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<SkillHasCategory> SkillHasCategories { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
	}
}
