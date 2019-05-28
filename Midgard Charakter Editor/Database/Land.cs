using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Database
{
    public class Land
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Land(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
