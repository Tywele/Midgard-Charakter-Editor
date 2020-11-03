using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Welche Sprachen jeder Charakter beherrscht.
    /// </summary>
    public class CharacterHasLanguage
    {
        public int Id { get; set; }

        public int       CharacterId { get; set; }
        public Character Character   { get; set; }

        public int      LanguageId { get; set; }
        public Language Language   { get; set; }

        public int SpeakingValue { get; set; }
        public int WritingValue  { get; set; }
    }
}