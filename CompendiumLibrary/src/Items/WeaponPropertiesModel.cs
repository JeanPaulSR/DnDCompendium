using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class WeaponPropertiesModel
    {
        public WeaponPropertiesModel(string name, int weaponPropertyId, Source source, string description)
        {
            Name = name;
            WeaponPropertyId = weaponPropertyId;
            Source = source;
            Description = description;
        }

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
