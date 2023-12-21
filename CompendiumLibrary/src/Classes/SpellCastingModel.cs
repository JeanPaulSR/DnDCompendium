using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompendiumLibrary.src.Classes
{
    public class SpellCastingModel
    {
        public SpellCastingModel(string name, int spellCastingId, 
            bool pactMagic, Dictionary<int, int[]> spellSlots, 
            Dictionary<int, int> cantripProjection, 
            Dictionary<int, int> spellsKnown)
        {
            Name = name;
            SpellCastingId = spellCastingId;
            PactMagic = pactMagic;
            SpellSlots = spellSlots;
            CantripProjection = cantripProjection;
            SpellsKnown = spellsKnown;
        }

        /// <summary>
        /// Name of the spellcasting style
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of the spellcasting style
        /// </summary>
        public int SpellCastingId { get; set; }

        /// <summary>
        /// Whether the spellcasting type is pactMagic (true)
        /// or not
        /// </summary>
        public bool PactMagic { get; set; }

        /// <summary>
        /// A dictionary which assigns each class level the slots available to them
        /// at each level. Expected to only show spell slot levels greater than 0
        /// with Pact Magic
        /// </summary>
        public Dictionary<int, int[]> SpellSlots = new(20);

        public string GetSpellSlots(int level)
        {
            string spells = "";
            int[] slots = SpellSlots[level];
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] == 0)
                    spells += "-";
                else
                    spells += slots[i].ToString();
                if (i < slots.Length - 1)
                    spells += " ";
            }
            return spells;
        }

        /// <summary>
        /// A dictionary which assigns each class level the cantrips known
        /// at each level. Can just check last level for any cantrips
        /// </summary>
        public Dictionary<int, int> CantripProjection = new(20);

        /// <summary>
        /// A dictionary which assigns each class level the spells known
        /// at each level
        /// </summary>
        public Dictionary<int, int> SpellsKnown = new(20);

        
    }
}
