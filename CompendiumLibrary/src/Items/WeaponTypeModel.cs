using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class WeaponTypeModel
    {
        /// <summary>
        /// The name of the armor type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the armor type
        /// </summary>
        public int ArmorTypeId { get; set; }


        /// <summary>
        /// The description of the armor type
        /// </summary>
        public string Description { get; set; }
    }
}
