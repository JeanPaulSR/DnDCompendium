using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class SpellScrollModel
    {
        /// <summary>
        /// The level of the spell contained within the spell scroll
        /// </summary>
        public int SpellLevel { get; set; }

        /// <summary>
        /// Id of the spell in the spell scroll
        /// </summary>
        public int SpellId { get; set; }
    }
}
