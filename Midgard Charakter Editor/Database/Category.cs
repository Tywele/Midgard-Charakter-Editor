using System.Collections.Generic;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Kategorien wie Alltag und Freiland (siehe Seite 158 im Kodex) oder auch Zauberkategorien wie Beherrschen und Formen.
    /// </summary>
    public class Category
    {
        public         int                           Id                 { get; set; }
        public         string                        Name               { get; set; }
        public virtual ICollection<SkillHasCategory> SkillHasCategories { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}