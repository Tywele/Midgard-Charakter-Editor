namespace MCE.Model
{
    /// <summary>
    /// Welche Fertigkeiten jeder Charakter gelernt hat.
    /// </summary>
    public class CharacterHasSkill
    {
        public int       Id             { get; set; }
        public Character Character      { get; set; }
        public Skill     Skill          { get; set; }
        public int       Value          { get; set; }
        public int       PracticePoints { get; set; }
        public string    Note           { get; set; }
    }
}