using MidgardCharakterEditor.Database;
using System;
using Xunit;

namespace Tests
{
    public class CharacterGeneratorTests
    {
        [Fact]
        public void ChooseRaceTest()
        {
            var character = new Character();
            var propertyInfo = typeof(Character).GetProperty("Strength");
            propertyInfo.SetValue(character, 10, null);
        }
    }
}
