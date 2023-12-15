using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    internal class VehicleModel
    {
        /// <summary>
        /// The type of the Vehicle
        /// </summary>
        public VehicleType VehicleType { get; set; }
    }

    internal class VehicleType { }
    internal class Land : VehicleType { }
    internal class Air : VehicleType { }
    internal class Water : VehicleType { }
}
