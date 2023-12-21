using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Classes
{
    public class ClassFeatureModel(string name, int featureId, string description)
    {
        /// <summary>
        /// Feature Name
        /// </summary>
        public string Name { get; set; } = name;


        /// <summary>
        /// The Feature ID
        /// </summary>
        public int FeatureId { get; set; } = featureId;

        /// <summary>
        /// Description of the feature
        /// </summary>
        public string Description = description;

        
    }
}
