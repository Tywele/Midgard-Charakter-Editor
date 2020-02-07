using System.Collections.Generic;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Zauber (siehe Arkanum).
    /// </summary>
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int ProcessId { get; set; }
        public Category Process { get; set; }

        public string Agent { get; set; }
        public string Reagent { get; set; }
        public string CastingCost { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Target { get; set; }
        public string AffectedArea { get; set; }
        public string Duration { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public int Level { get; set; }
        public int LearningCost { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public bool PossibleStarter { get; set; }

        public virtual ICollection<CharacterHasSpell> CharacterHasSpells { get; set; }

        public Spell(int id, string name, string type, int processId, string agent, string reagent, string castingCost, 
            string castingTime, string range, string target, string affectedArea, string duration, string origin, 
            string material, int level, int learningCost, int categoryId, bool possibleStarter = false)
        {
            Id = id;
            Name = name;
            Type = type;
            ProcessId = processId;
            Agent = agent;
            Reagent = reagent;
            CastingCost = castingCost;
            CastingTime = castingTime;
            Range = range;
            Target = target;
            AffectedArea = affectedArea;
            Duration = duration;
            Origin = origin;
            Material = material;
            Level = level;
            LearningCost = learningCost;
            CategoryId = categoryId;
            PossibleStarter = possibleStarter;
        }
    }
}
