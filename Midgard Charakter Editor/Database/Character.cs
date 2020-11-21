using System.Collections.Generic;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Ein Charakter.
    /// </summary>
    public class Character
    {
        public int         Id           { get; set; }
        public string      Name         { get; set; }
        public Race        Race         { get; set; }
        public Class       Class        { get; set; }
        public int         Age          { get; set; }
        public string      Size         { get; set; }
        public string      Weight       { get; set; }
        public string      Build        { get; set; }
        public string      Handedness   { get; set; }
        public SocialClass SocialClass  { get; set; }
        public Land        Origin       { get; set; }
        public string      Religion     { get; set; }
        public int         SmilingFate  { get; set; }
        public int         DivineMercy  { get; set; }
        public string      Story        { get; set; }
        public int         Strength     { get; set; }
        public int         Dexterity    { get; set; }
        public int         Agility      { get; set; }
        public int         Constitution { get; set; }
        public int         Intelligence { get; set; }
        public int         MagicTalent  { get; set; }
        public int         Health       { get; set; }
        public int         Stamina      { get; set; }
        public int         Appearance   { get; set; }
        public int         Charisma     { get; set; }
        public int         Defense      { get; set; }
        public int         Resistance   { get; set; }
        public int         Movement     { get; set; }
        public int         Xp           { get; set; }
        public int         Level        { get; set; }
        public int         OpenXp       { get; set; }

        public List<CharacterHasSpell>       CharacterHasSpells       { get; set; } = new List<CharacterHasSpell>();
        public List<CharacterHasSkill>       CharacterHasSkills       { get; set; } = new List<CharacterHasSkill>();
        public List<CharacterHasWeapon>      CharacterHasWeapons      { get; set; } = new List<CharacterHasWeapon>();
        public List<CharacterHasInnateSkill> CharacterHasInnateSkills { get; set; } = new List<CharacterHasInnateSkill>();
        public List<CharacterHasLanguage>    CharacterHasLanguages    { get; set; } = new List<CharacterHasLanguage>();
    }
}