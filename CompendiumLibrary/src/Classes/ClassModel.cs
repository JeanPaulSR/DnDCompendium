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
    public class ClassModel
    {
        /// <summary>
        /// Class Name
        /// </summary>
        private string Name { get; set; } = string.Empty;
        public string GetName () { return Name; }
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
        private Dictionary<int, List<ClassFeatureModel>> Features = new(20);
        public Dictionary<int, List<ClassFeatureModel>> GetFeatures () { return Features; }

        /// <summary>
        /// Boolean to determin whether the class has any manner of 
        /// spellcasting
        /// </summary>
        private bool HasSpellCasting { get; set; }
        public bool HasSpellCastingCheck() { return HasSpellCasting; }

        /// <summary>
        /// Spellcasting scaling for the class
        /// </summary>
        private SpellCastingModel SpellCasting { get; set; }
        public SpellCastingModel GetSpellCasting () { return SpellCasting; }

        /// <summary>
        /// Map of the spells avaible for each level. The Map 0 is used for cantrips
        /// </summary>
        public Dictionary<int, List<SpellModel>> SpellList = new(9);

        /// <summary>
        /// Scaling features of the class
        /// </summary>
        private List<ScalingModel> Scalings = [];

        public List<ScalingModel> GetScalings() { return Scalings; }

        /// <summary>
        /// Description of the class
        /// </summary>
        public string Description = string.Empty;

        public ClassModel(string name, Source source, int classId, string hitDice,
            ProficiencyModel prof, MulticlassModel multiClass, List<int> subclassLevels,
            List<SubclassModel> subclasses, List<int> compendiums, List<List<string>> equipment,
            Dictionary<int, List<ClassFeatureModel>> features, bool hasSpellCasting,
            SpellCastingModel spellCasting, Dictionary<int, List<SpellModel>> spellList,
            List<ScalingModel> scalings, string description)
        {
            Name = name;
            Source = source;
            ClassId = classId;
            HitDice = hitDice;
            Proficiency = prof;
            Mullticlass = multiClass;
            SubclassFeatureLevels = subclassLevels;
            Subclasses = subclasses;
            CompendiumId = compendiums;
            Equipment = equipment;
            Features = features;
            HasSpellCasting = hasSpellCasting;
            SpellCasting = spellCasting;
            SpellList = spellList;
            Scalings = scalings;
            Description = description;
        }
    }
}
