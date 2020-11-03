using System;

namespace MidgardCharakterEditor.Utilities
{
    /// <summary>
    /// Eine Klasse mit der man einen beliebig großen Würfel würfeln kann.
    /// </summary>
    public class Die : IDie
    {
        /// <summary>
        /// Würfelt den Würfel mit der angegebenen Anzahl an <paramref name="eyes"/>.
        /// </summary>
        /// <param name="eyes">Anzahl der Würfelaugen</param>
        /// <returns></returns>
        public int Roll(int eyes)
        {
            return new Random(new Random().Next()).Next(1, eyes);
        }
    }
}