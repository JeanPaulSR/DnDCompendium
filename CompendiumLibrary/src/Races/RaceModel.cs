using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.UniversalTraits;

namespace CompendiumLibrary.src.Races
{
    public class RaceModel
    { 
        /// <summary>
        /// The name of the race
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ability score increase gained by choosing this race
        /// </summary>
        public string AbilityScoreIncrease { get; set; }

        /// <summary>
        /// The creature type of the race
        /// </summary>
        public CreatureType Type { get; set; }

        /// <summary>
        /// The size of the race
        /// </summary>
        public CreatureSize Size { get; set; }

        /// <summary>
        /// The race's differnt speeds
        /// </summary>
        public CreatureSpeedModel Speed { get; set; }

        /// <summary>
        /// The race's racial features
        /// </summary>
        public List<RacialFeatureModel> RacialFeatures = [];


    }
}
