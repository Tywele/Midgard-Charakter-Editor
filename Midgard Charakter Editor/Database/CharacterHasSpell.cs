namespace MidgardCharakterEditor.Database
{
	public class CharacterHasSpell
	{
		/// <summary>
		/// Welche Zauber jeder Charakter beherrscht.
		/// </summary>
		public int Id { get; set; }
		public Character Character { get; set; }
		public Spell Spell { get; set; }
	}
}