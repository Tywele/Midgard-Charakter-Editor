namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Die Kosten zum Steigern einer Verteidigungswaffe (siehe Seite 161 unten im Kodex).
    /// </summary>
    public class DefenseWeaponTrainingCost
    {
        public int Id    { get; set; }
        public int Value { get; set; }
        public int Cost  { get; set; }

        public DefenseWeaponTrainingCost(int id, int value, int cost)
        {
            Id    = id;
            Value = value;
            Cost  = cost;
        }
    }
}