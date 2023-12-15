using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.UniversalTraits
{
    /// <summary>
    /// Languages are divided into Common, Exotic and Special for
    /// their rarity.
    /// </summary>
    internal class LanguageModel
    {
        /// <summary>
        /// The type of language, common or exotic
        /// </summary>
        public LanguageType LanguageType { get; set; }

        /// <summary>
        /// The name of the language
        /// </summary>
        public string LanguageName { get; set; }
    }

    /// <summary>
    /// The different language types, common and exotic. As well
    /// as special if it does not fall into either one
    /// </summary>
    internal enum LanguageType
    {
        Common,
        Exotic,
        Special,
    }
}
