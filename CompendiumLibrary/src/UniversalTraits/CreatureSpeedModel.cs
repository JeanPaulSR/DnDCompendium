using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.UniversalTraits
{
    /// <summary>
    /// A creature's speed, which consists of
    /// Burrow, Climb, Fly, Hover, Swim and Walk
    /// </summary>
    internal class CreatureSpeedModel
    {
        /// <summary>
        /// A creature's burrow speed
        /// </summary>
        public int Burrow { get; set; }

        /// <summary>
        /// A creature's climb speed
        /// </summary>
        public int Climb { get; set; }

        /// <summary>
        /// A creature's fly speed
        /// </summary>
        public int Fly { get; set; }

        /// <summary>
        /// A creature's hover speed
        /// </summary>
        public int Hover { get; set; }

        /// <summary>
        /// A creature's swim speed
        /// </summary>
        public int Swim { get; set; }

        /// <summary>
        /// A creature's walk speed
        /// </summary>
        public int Walk { get; set; }

    }
}
