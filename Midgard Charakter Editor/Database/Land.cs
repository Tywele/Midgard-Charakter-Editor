using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die verschiedenen Länder Midgards aus denen der Charakter stammen kann (siehe Seite 30-32 im Kodex).
    /// </summary>
    public class Land
    {
        public int    Id   { get; set; }
        public string Name { get; set; }

        public Land(int id, string name)
        {
            Id   = id;
            Name = name;
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}