using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Spells
{
    public class SpellModel
    {
        /// <summary>
        /// The name of the spell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id the of the spell
        /// </summary>
        public int SpellId { get; set; }    

        /// <summary>
        /// The spell's level
        /// </summary>
        public int SpellLevel { get; set; }

        /// <summary>
        /// Magic school of the spell
        /// </summary>
        public School SpellSchool { get; set; }
        /// <summary>
        /// The spell's source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Whether the spell is a ritual (true)
        /// or not (false)
        /// </summary>
        public bool IsRitual { get; set; }

        /// <summary>
        /// Whether the spell requires concentration or not
        /// </summary>
        public bool IsConcentration { get; set; }

        /// <summary>
        /// Whether the spell requires verbal components
        /// </summary>
        public bool HasVerbal { get; set; }

        /// <summary>
        /// Whether the spell requires somatic components
        /// </summary>
        public bool HasSomatic { get; set; }

        /// <summary>
        /// Whether the spell requires material components
        /// </summary>
        public bool HasMaterial { get; set; }

        /// <summary>
        /// The spell's material components
        /// </summary>
        public string MaterialComponents { get; set; }

        /// <summary>
        /// The spell's range
        /// </summary>
        public string Range { get; set; }

        /// <summary>
        /// The spell's duration
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// The spell's cast time
        /// </summary>
        public string CastTime { get; set; }
        /// <summary>
        /// The description of the spell
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// The schools of magic within dnd
    /// </summary>
    public enum School
    {
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }
}
