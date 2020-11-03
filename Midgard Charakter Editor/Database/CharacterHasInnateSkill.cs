using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Database
{
    /// <summary>
    /// Welche angeborenen Fertigkeiten (siehe ab Seite 96 im Kodex) jeder Charakter hat.
    /// </summary>
    public class CharacterHasInnateSkill
    {
        public int Id { get; set; }

        public int         InnateSkillId { get; set; }
        public InnateSkill InnateSkill   { get; set; }

        public int       CharacterId { get; set; }
        public Character Character   { get; set; }
    }
}