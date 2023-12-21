using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Classes
{
    public class ScalingModel
    {
        /// <summary>
        /// Name of the scaling resource
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of the scaling feature
        /// </summary>
        public int ScalingId { get; set; }  

        /// <summary>
        /// Map of the assigned scaling for each level
        /// </summary>
        private Dictionary<int, string> Scaling = new(20);

        public Dictionary<int, string> GetScaling() { return Scaling; }
    }
}
