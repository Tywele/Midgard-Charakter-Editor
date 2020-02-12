using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MidgardCharakterEditor.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Generators
{
    public class CharacterGenerator
    {
        public Character Character { get; set; }

        public CharacterGenerator()
        {
            Character = new Character();
        }

        public void ChooseRace(Race race)
        {
            Character.Race = race;
        }

        public void RollAttributes(int method)
        {
            if (method == 1)
            {
                
            }
            else
            {

            }
        }

        public void SetAttribute(PropertyInfo propertyInfo, int value)
        {
            propertyInfo.SetValue(Character, value);
        }
    }
}
