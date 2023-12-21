using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src
{
    public class Source
    {
        /// <summary>
        /// Name of the source
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Website or location that the source can be found from
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The Abbreviation of the source, ie: PHB (Player's Handbook)
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// The primary author or authors of the work
        /// </summary>
        public string Author { get; set; }
    }
}
