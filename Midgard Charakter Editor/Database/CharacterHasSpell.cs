namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Welche Zauber jeder Charakter beherrscht.
    /// </summary>
    public class CharacterHasSpell
    {
        public int Id { get; set; }
        public Character Character { get; set; }
        public Spell Spell { get; set; }
    }
}