using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class ArmorPropertiesModel
    {
        /// <summary>
        /// The name of the Armor property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the Armor property
        /// </summary>
        public int ArmorPropertyId { get; set; }

        /// <summary>
        /// The source of the Armor property
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The description of the Armor property
        /// </summary>
        public string Description { get; set; }
    }
}
