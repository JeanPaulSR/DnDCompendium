using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class WeaponModel : ItemModel
    {
        /// <summary>
        /// If the weapon is a melee weapon (false)
        /// or a ranged weapon (true)
        /// </summary>
        public bool IsRanged { get; set; }

        /// <summary>
        /// The range of the weapon
        /// </summary>
        public string Range { get; set; }

        /// <summary>
        /// The base damage dice of the weapon
        /// </summary>
        public string DamageDice { get; set; }

        /// <summary>
        /// The alternage damage dice of the weapon
        /// </summary>
        public string AlternateDamageDice { get; set; }

        /// <summary>
        /// The damage type of the weapon
        /// </summary>
        public string DamageType { get; set; }

        /// <summary>
        /// The weapon properties of the weapon
        /// </summary>
        public List<WeaponPropertiesModel> WeaponProperties = [];

        /// <summary>
        /// The description of the weapon 
        /// </summary>
        public string Description { get; set; }
    }
}
