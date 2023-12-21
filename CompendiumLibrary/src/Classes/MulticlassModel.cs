using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.Items;
using CompendiumLibrary.src.UniversalTraits;

namespace CompendiumLibrary.src.Classes
{
    public class MulticlassModel
    {

        public MulticlassModel(string requirements, bool chooseSkills,
            int chooseSkillsNumber, List<Skill> skillsList,
            List<Skill> chooseSkillsList, bool chooseSavingThrows,
            int chooseSavingThrowsNumber, List<Abilities> savesList,
            List<Abilities> chooseSavesList,
            List<WeaponTypeModel> weaponProficiencies,
            List<ArmorTypeModel> armorProficiencies,
            List<ToolModel> toolProficiencies,
            List<LanguageModel> languageProficiencies)
        {
            Requirements = requirements;
            ChooseSkills = chooseSkills;
            ChooseSkillsNumber = chooseSkillsNumber;
            SkillsList = skillsList;
            ChooseSkillsList = chooseSkillsList;
            ChooseSavingThrows = chooseSavingThrows;
            ChooseSavingThrowsNumber = chooseSavingThrowsNumber;
            SavesList = savesList;
            ChooseSavesList = chooseSavesList;
            WeaponProficiencies = weaponProficiencies;
            ArmorProficiencies = armorProficiencies;
            ToolProficiencies = toolProficiencies;
            LanguageProficiencies = languageProficiencies;
        }

        /// <summary>
        /// Multiclassing requirements
        /// </summary>
        public string Requirements { get; set; } = string.Empty;

        /// <summary>
        /// Whether skills can be chosen (true)
        /// or are just given (false)
        /// </summary>
        public bool ChooseSkills;

        /// <summary>
        /// How many skills are allowed to be chosen
        /// when selecting class skills
        /// </summary>
        public int ChooseSkillsNumber { get; set; }

        /// <summary>
        /// List that tracks which proficiencies are chosen for multiclassing
        /// </summary>
        public List<Skill> SkillsList { get; set; } = [];
        /// <summary>
        /// List that tracks which proficiencies can be chosen for multiclassing
        /// </summary>
        public List<Skill> ChooseSkillsList { get; set; } = [];

        /// <summary>
        /// Whether saving throws can be chosen (true)
        /// or are just given (false)
        /// </summary>
        public bool ChooseSavingThrows;

        /// <summary>
        /// How many saving throws are allowed to be chosen
        /// when selecting class skills
        /// </summary>
        public int ChooseSavingThrowsNumber { get; set; }

        /// <summary>
        /// List that tracks which saving throws are chosen for a multiclass
        /// </summary>
        public List<Abilities> SavesList { get; set; } = [];
        /// <summary>
        /// List that tracks which saving throws can be chosen for a multiclass
        /// </summary>
        public List<Abilities> ChooseSavesList { get; set; } = [];

        /// <summary>
        /// List of Weapon Proficiencies when selecting the class
        /// </summary>
        public List<WeaponTypeModel> WeaponProficiencies = [];

        /// <summary>
        /// List of Armor Proficiencies when selecting the class
        /// </summary>
        public List<ArmorTypeModel> ArmorProficiencies = [];

        /// <summary>
        /// List of Tool Proficiencies when selecting the class
        /// </summary>
        public List<ToolModel> ToolProficiencies = [];

        /// <summary>
        /// List of Tool Proficiencies when selecting the class
        /// </summary>
        public List<LanguageModel> LanguageProficiencies = [];
    }
}
