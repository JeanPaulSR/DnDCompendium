using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.Items;
using CompendiumLibrary.src.UniversalTraits;

namespace CompendiumLibrary.src.Backgrounds
{
    public class BackgroundModel
    {
        /// <summary>
        /// The name of the background
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether skills can be chosen (true)
        /// or are just given (false)
        /// </summary>
        public bool ChooseSkills;

        /// <summary>
        /// How many skills are allowed to be chosen
        /// when selecting background skills
        /// </summary>
        public int ChooseSkillsNumber { get; set; }

        /// <summary>
        /// List that tracks which proficiencies are chosen for a background
        /// </summary>
        public List<Skill> SkillsList { get; set; } = [];
        /// <summary>
        /// List that tracks which proficiencies can be chosen for a background
        /// </summary>
        public List<Skill> ChooseSkillsList { get; set; } = [];

        /// <summary>
        /// Features given by the background
        /// </summary>
        public List<BackgroundFeatureModel> BackgroundFeatures = [];

        /// <summary>
        /// List of Weapon Proficiencies when selecting the background
        /// </summary>
        public List<WeaponTypeModel> WeaponProficiencies = [];

        /// <summary>
        /// List of Armor Proficiencies when selecting the background
        /// </summary>
        public List<ArmorTypeModel> ArmorProficiencies = [];

        /// <summary>
        /// List of Tool Proficiencies when selecting the background
        /// </summary>
        public List<ToolModel> ToolProficiencies = [];

        /// <summary>
        /// List of Tool Proficiencies when selecting the background
        /// </summary>
        public List<LanguageModel> LanguageProficiencies = [];
    }
}
