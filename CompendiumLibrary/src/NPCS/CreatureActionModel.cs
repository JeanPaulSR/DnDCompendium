using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.NPCS
{
    public class CreatureActionModel
    {
        /// <summary>
        /// The Creature Action name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Action ID
        /// </summary>
        public int FeatureId { get; set; }

        /// <summary>
        /// The description of the creature Action
        /// </summary>
        public string Description { get; set; }
    }
}
