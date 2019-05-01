using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
    public class DefenseWeaponLearningCost
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }

        public DefenseWeaponLearningCost(int id, int value, int cost)
        {
            Id = id;
            Value = value;
            Cost = cost;
        }
    }
}
