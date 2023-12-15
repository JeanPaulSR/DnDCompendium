using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Feats
{
    internal class FeatModel
    {
        /// <summary>
        /// The name of the feat
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id the of the feat
        /// </summary>
        public int FeatId { get; set; }

        /// <summary>
        /// The prerequisite of the feat
        /// </summary>
        public string Prerequisite { get; set; }

        /// <summary>
        /// The description of the spell
        /// </summary>
        public string Description { get; set; }
    }
}
