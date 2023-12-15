using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Backgrounds
{
    internal class BackgroundFeatureModel
    {
        /// <summary>
        /// Feature Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The Feature ID
        /// </summary>
        public int FeatureId { get; set; }

        /// <summary>
        /// Description of the feature
        /// </summary>
        public string Description = string.Empty;
    }
}
