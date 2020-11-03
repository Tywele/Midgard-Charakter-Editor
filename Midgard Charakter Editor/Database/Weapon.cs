using System.Collections.Generic;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Waffen.
    /// </summary>
    public class Weapon
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Damage       { get; set; }
        public string StormDamage  { get; set; }
        public string Protection   { get; set; }
        public int    MinStrength  { get; set; }
        public int    MinDexterity { get; set; }
        public int    MinAgility   { get; set; }
        public string Description  { get; set; }
        public string Note         { get; set; }
        public string Range        { get; set; }

        public int   WeaponGroupId { get; set; }
        public Skill WeaponGroup   { get; set; }

        public virtual ICollection<CharacterHasWeapon> CharacterHasWeapons { get; set; }

        public Weapon(int    id,           string name,       string damage,
                      string stormDamage,  string protection, int    minStrength,
                      int    minDexterity, int    minAgility, string note, string range, int weaponGroupId)
        {
            Id            = id;
            Name          = name;
            Damage        = damage;
            StormDamage   = stormDamage;
            Protection    = protection;
            MinStrength   = minStrength;
            MinDexterity  = minDexterity;
            MinAgility    = minAgility;
            Note          = note;
            Range         = range;
            WeaponGroupId = weaponGroupId;

            CharacterHasWeapons = new HashSet<CharacterHasWeapon>();
        }
    }
}