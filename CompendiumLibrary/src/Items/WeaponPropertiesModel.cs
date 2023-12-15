using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class WeaponPropertiesModel
    {
        /// <summary>
        /// The name of the weapon property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the weapon property
        /// </summary>
        public int WeaponPropertyId { get; set; }

        /// <summary>
        /// The source of the weapon property
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The description of the weapon property
        /// </summary>
        public string Description { get; set; }
    }
}
