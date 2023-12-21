using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class WeaponTypeModel
    {
        public WeaponTypeModel(string name, int weaponTypeId, string description)
        {
            Name = name;
            WeaponTypeId = weaponTypeId;
            Description = description;
        }

        /// <summary>
        /// The name of the weapon type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the weapon type
        /// </summary>
        public int WeaponTypeId { get; set; }


        /// <summary>
        /// The description of the weapon type
        /// </summary>
        public string Description { get; set; }
    }
}
