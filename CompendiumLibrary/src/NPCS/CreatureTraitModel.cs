using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.NPCS
{
    public class CreatureTraitModel
    {
        /// <summary>
        /// The Creature Trait name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Trait ID
        /// </summary>
        public int FeatureId { get; set; }

        /// <summary>
        /// The description of the creature trait
        /// </summary>
        public string Description { get; set; }
    }
}
