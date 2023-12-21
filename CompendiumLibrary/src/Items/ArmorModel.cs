using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class ArmorModel :ItemModel
    {
        /// <summary>
        /// The Armor Type of the Armor
        /// </summary>
        public ArmorTypeModel ArmorType { get; set; }

        /// <summary>
        /// The properties of the armor
        /// </summary>
        public List<ArmorPropertiesModel> ArmorProperties = [];
    }
}
