namespace MidgardCharakterEditor.Database
{
	public class CharacterHasSpell
	{
		public int Id { get; set; }
		public Character Character { get; set; }
		public Spell Spell { get; set; }
	}
}