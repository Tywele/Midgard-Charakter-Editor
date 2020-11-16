namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Klassen (siehe Seite 23 im Kodex).
    /// </summary>
    public class Class
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Abbreviation { get; set; }
        public int    Type         { get; set; }

        public Class(int id, string name, string abbreviation, int type)
        {
            Id           = id;
            Name         = name;
            Abbreviation = abbreviation;
            Type         = type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}