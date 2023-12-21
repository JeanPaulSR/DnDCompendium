using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.Spells;

namespace CompendiumLibrary.src.Items
{
    public class ItemModel
    {
        /// <summary>
        /// The item name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether the item requires Attunement or not
        /// </summary>
        public bool Attunement { get; set; }

        /// <summary>
        /// The rarity of the item
        /// </summary>
        public string Rarity;

        /// <summary>
        /// The weight of the item in pounds
        /// </summary>
        public int Weight;

        /// <summary>
        /// The cost of the item in gold
        /// </summary>
        public int Cost;

        /// <summary>
        /// The number of charges the item has
        /// </summary>
        public int Charges;

        /// <summary>
        /// The recovery formula for the item after it expends charges
        /// </summary>
        public string Recovery;

        /// <summary>
        /// The description of the item
        /// </summary>
        public string Description { get; set; }
    }
}
