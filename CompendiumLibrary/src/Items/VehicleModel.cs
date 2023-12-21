using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Items
{
    public class VehicleModel
    {
        /// <summary>
        /// The type of the Vehicle
        /// </summary>
        public VehicleType VehicleType { get; set; }
    }

    public class VehicleType { }
    public class Land : VehicleType { }
    public class Air : VehicleType { }
    public class Water : VehicleType { }
}
