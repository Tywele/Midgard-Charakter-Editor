namespace MCE.Model
{
    /// <summary>
    /// Die Sprachen, die in Midgard gesprochen werden (siehe Seite 127 im Kodex).
    /// </summary>
    public class Language
    {
        public int    Id   { get; set; }
        public string Name { get; set; }

        public Language(int id, string name)
        {
            Id   = id;
            Name = name;
        }
    }
}