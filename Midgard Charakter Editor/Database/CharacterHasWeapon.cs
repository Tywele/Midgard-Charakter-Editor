namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Jede Waffe mit der jeder Charakter den Umgang gelernt hat.
    /// </summary>
    public class CharacterHasWeapon
    {
        public int Id { get; set; }

        public int       CharacterId { get; set; }
        public Character Character   { get; set; }

        public int    WeaponId { get; set; }
        public Weapon Weapon   { get; set; }

        public int  Value          { get; set; }
        public int  PracticePoints { get; set; }
        public bool Specialization { get; set; }
    }
}