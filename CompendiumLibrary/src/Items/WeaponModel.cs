using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class WeaponModel : ItemModel
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

        public WeaponModel(string name, bool attunement, string rarity, 
            int weight, int cost, int charges, string recovery, string description, 
            bool isRanged, string range, string damageDice, string alternateDamageDice,
            string damageType, List<WeaponPropertiesModel> weaponProperties
            )
        {
            IsRanged = isRanged;
            Range = range;
            DamageDice = damageDice;
            AlternateDamageDice = alternateDamageDice;
            DamageType = damageType;
            WeaponProperties = weaponProperties;
            Name = name;
            Attunement = attunement;
            Rarity = rarity;
            Weight = weight;
            Cost = cost;
            Charges = charges;
            Recovery = recovery;
            Description = description;
        }
    }
}
