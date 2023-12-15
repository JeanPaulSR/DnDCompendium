using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class WondrousItemModel : ItemModel
    {
        /// <summary>
        /// Whether the item is an instrument (true) or not (false)
        /// </summary>
        public bool IsInstrument { get; set; }
    }
}
