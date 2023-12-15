using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.Classes;
using CompendiumLibrary.src;
using CompendiumLibrary.src.Classes;
using CompendiumLibrary.src.Spells;

namespace CompendiumLibrary
{
    internal class ClassModel
    {
        /// <summary>
        /// Class Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The class's source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The Class ID
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// The Class Hit Dice
        /// </summary>
        public string HitDice { get; set; } = string.Empty;

        /// <summary>
        /// The various proficiencies gained when selecting the class
        /// </summary>
        public ProficiencyModel Proficiency { get; set; }

        /// <summary>
        /// The various proficiencies gained when multiclassing into the class
        /// </summary>
        public MulticlassModel Mullticlass {  get; set; }

        /// <summary>
        /// Levels that the class gains subclass features
        /// </summary>
        public List<int> SubclassFeatureLevels { get; set; }

        /// <summary>
        /// List of subclasses applicable for this class
        /// </summary>
        public List<SubclassModel> Subclasses { get; set; } = [];

        /// <summary>
        /// List of the various compendiums the Class belongs to
        /// </summary>
        public List<int> CompendiumId { get; set; } = [];

        /// <summary>
        /// List of starting equipment options
        /// </summary>
        public List<List<string>> Equipment = [];

        /// <summary>
        /// Map of the features assigned for each level
        /// </summary>
        public Dictionary<int, List<ClassFeatureModel>> Features = new(20);

        /// <summary>
        /// Boolean to determin whether the class has any manner of 
        /// spellcasting
        /// </summary>
        public bool HasSpellCasting { get; set; }

        /// <summary>
        /// Spellcasting scaling for the class
        /// </summary>
        public SpellCastingModel SpellCasting { get; set; }

        /// <summary>
        /// Map of the spells avaible for each level. The Map 0 is used for cantrips
        /// </summary>
        public Dictionary<int, List<SpellModel>> SpellList = new(9);

        /// <summary>
        /// Scaling features of the class
        /// </summary>
        public List<ScalingModel> Scalings = [];

        /// <summary>
        /// Description of the class
        /// </summary>
        public string Description = string.Empty;


    }
}
