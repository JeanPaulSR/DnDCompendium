using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.UniversalTraits;

namespace CompendiumLibrary.src.NPCS
{
    internal class NpcModel
    {
        /// <summary>
        /// The name of the NPC
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Npc's creature type
        /// </summary>
        public CreatureType Type { get; set; }

        /// <summary>
        /// The Npc's creature size
        /// </summary> 
        public CreatureSize Size { get; set; }

        /// <summary>
        /// A creature's different speeds
        /// </summary>
        public CreatureSpeedModel Speed { get; set; }

        /// <summary>
        /// A creature's alignment
        /// </summary>
        public Alignment Alignment { get; set; }

        /// <summary>
        /// A creature's armor class
        /// </summary>
        public string AC {  get; set; }

        /// <summary>
        /// A creature's hit points
        /// </summary>
        public string HP { get; set; }

        /// <summary>
        /// Dictionary of the different abilities
        /// Key: Ability, Value: (Score, Saving Throw)
        /// </summary>
        public Dictionary<Abilities, (int, int)> AbilityScore { get; set; } = new Dictionary<Abilities, (int, int)>(6);

        /// <summary>
        /// A creature's specific bonuses to skills
        /// </summary>
        public Dictionary<Skill, int> Skills { get; set; }

        /// <summary>
        /// A creature's damage resistances
        /// </summary>
        public string DamageResistance { get; set; }

        /// <summary>
        /// A creature's damage immunities
        /// </summary>
        public string DamageImmunities { get; set; }

        /// <summary>
        /// A creature's condition immunities
        /// </summary>
        public string ConditionImmunities { get; set; }

        /// <summary>
        /// A creature's senses
        /// </summary>
        public string Senses { get; set; }

        /// <summary>
        /// A creature's languages
        /// </summary>
        public string Languages { get; set; }

        /// <summary>
        /// A creature's challenge rating
        /// </summary>
        public string ChallengeRating { get; set; }

        /// <summary>
        /// A creature's enviroments
        /// </summary>
        public string Enviroment { get; set; }

        /// <summary>
        /// A creature's traits
        /// </summary>
        public List<CreatureTraitModel> CreatureTraits { get; set; } = [];

        /// <summary>
        /// A creature's actions
        /// </summary>
        public List<CreatureActionModel> CreatureAction { get; set; } = [];


    }
}
