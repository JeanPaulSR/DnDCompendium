using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class PoisonModel
    {
        /// <summary>
        /// The type of poison
        /// </summary>
        public PoisonType PoisonType { get; set; }
    }

    /// <summary>
    /// The types of poison: Contact, Inhaled and Injested
    /// </summary>
    public enum PoisonType
    {
        Contact,
        Inhaled,
        Injested
    }
}
