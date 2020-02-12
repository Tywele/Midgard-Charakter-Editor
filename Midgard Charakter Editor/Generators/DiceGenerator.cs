using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCharakterEditor.Generators
{
    /// <summary>
    /// Mit dieser Klasse können Würfel beliebiger Anzahl und Augenzahl erzeugt werden.
    /// </summary>
    public class DiceGenerator
    {
        private readonly int _count;
        private readonly int _eyes;

        public DiceGenerator(int count, int eyes)
        {
            _count = count;
            _eyes = eyes;
        }

        /// <summary>
        /// Würfelt alle Würfel des Würfel Generators und gibt das Gesamtergebnis zurück.
        /// </summary>
        /// <returns></returns>
        public int RollDice()
        {
            int counter = 0;
            int result = 0;

            while (counter < _count)
            {
                result += new Random(new Random().Next()).Next(1, _eyes);
                counter++;
            }

            return result;
        }

        /// <summary>
        /// Würfelt alle Würfel des Würfel Generators und gibt alle Ergebnisse der Würfel in einer Liste zurück.
        /// </summary>
        /// <returns></returns>
        public List<int> RollSeparateDice()
        {
            int counter = 0;
            var result = new List<int>();

            while (counter < _count)
            {
                result.Add(new Random(new Random().Next()).Next(1, _eyes));
                counter++;
            }

            return result;
        }
    }
}
