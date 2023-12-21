using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.Spells;

namespace CompendiumLibrary.src.Classes
{
    public class SubclassModel
    {
        /// <summary>
        /// Subclass Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The subclass's source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The main Class ID
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// The sublass ID
        /// </summary>
        public int SubclassId { get; set; }

        /// <summary>
        /// List of subclass features. Expected to be
        /// the same size as main Class's subclass feature
        /// breakpoint levels
        /// </summary>
        public List<ClassFeatureModel> Features = [];

        /// <summary>
        /// Boolean to determin whether the subclass has any manner of 
        /// spellcasting. And if it should replace it's parent classes
        /// spellcasting
        /// </summary>
        public bool HasSpellCasting { get; set; }

        /// <summary>
        /// Spellcasting scaling for the class
        /// </summary>
        public SpellCastingModel SpellCasting { get; set; }

        /// <summary>
        /// Scaling features of the class
        /// </summary>
        public List<ScalingModel> Scalings = [];

        /// <summary>
        /// Map of the spells avaible for each level. The Map 0 is used for cantrips
        /// Any spells added are appended to the end of the main classes spells
        /// </summary>
        public Dictionary<int, List<SpellModel>> SpellList = new(9);
    }
}
