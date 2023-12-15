using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Classes
{
    internal class ScalingModel
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
        public Dictionary<int, string> Scaling = new(20);


    }
}
