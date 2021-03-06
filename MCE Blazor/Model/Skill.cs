﻿using System.Collections.Generic;

namespace MCE.Model
{
    /// <summary>
    /// Die Fertigkeiten (siehe Seite 100ff im Kodex).
    /// </summary>
    public class Skill
    {
        public int    Id               { get; set; }
        public string Name             { get; set; }
        public string LeadingAttribute { get; set; }
        public string Field            { get; set; }
        public int?   Untrained        { get; set; }
        public string Description      { get; set; }
        public int    InitialValue     { get; set; }
        public bool   PossibleStarter  { get; set; }

        public List<SkillHasCategory>  SkillHasCategories { get; set; } = new List<SkillHasCategory>();
        public List<CharacterHasSkill> CharacterHasSkills { get; set; } = new List<CharacterHasSkill>();

        public Skill(int id, string name, string leadingAttribute, string field, int initialValue, bool possibleStarter,
                     int? untrained = null)
        {
            Id               = id;
            Name             = name;
            LeadingAttribute = leadingAttribute;
            Field            = field;
            Untrained        = untrained;
            InitialValue     = initialValue;
            PossibleStarter  = possibleStarter;
        }
    }
}