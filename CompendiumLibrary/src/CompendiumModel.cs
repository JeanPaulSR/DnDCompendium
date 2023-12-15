using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CompendiumLibrary.src.Backgrounds;
using CompendiumLibrary.src.Feats;
using CompendiumLibrary.src.Items;
using CompendiumLibrary.src.NPCS;
using CompendiumLibrary.src.Races;
using CompendiumLibrary.src.Spells;

namespace CompendiumLibrary.src
{
    internal class CompendiumModel
    {
        /// <summary>
        /// The Compendium ID
        /// </summary>
        public int CompendiumId { get; set; }

        /// <summary>
        /// The Compendium's Name
        /// </summary>
        public string CompendiumName { get; set; } = string.Empty;

        /// <summary>
        /// List of Classes that belong to this Compendium
        /// </summary>
        public List<ClassModel> Classes { get; set; } = [];

        public List<ItemModel> Items { get; set; } = [];
        public List<SpellModel> Spells { get; set; } = [];
        public List<FeatModel> Feats { get; set; } = [];
        public List<BackgroundModel> Backgrounds { get; set; } = [];
        public List<RaceModel> Races { get; set; } = [];
        public List<NpcModel> Npcs { get; set; } = [];
    }
}
