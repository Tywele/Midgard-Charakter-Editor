using System.Collections.Generic;

namespace MCE.Model
{
    /// <summary>
    /// Die angeborenen Fertigkeiten (siehe Seite 27 im Kodex).
    /// </summary>
    public class InnateSkill
    {
        public int    Id        { get; set; }
        public string Name      { get; set; }
        public string Value     { get; set; }
        public int    MinChance { get; set; }
        public int    MaxChance { get; set; }

        public List<CharacterHasInnateSkill> CharacterHasInnateSkills { get; set; } = new List<CharacterHasInnateSkill>();

        public InnateSkill(int id, string name, string value, int minChance, int maxChance)
        {
            Id        = id;
            Name      = name;
            Value     = value;
            MinChance = minChance;
            MaxChance = maxChance;
        }
    }
}