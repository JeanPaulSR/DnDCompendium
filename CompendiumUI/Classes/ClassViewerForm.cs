using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompendiumLibrary.src.Classes;
using CompendiumLibrary.src.Items;
using CompendiumLibrary.src.UniversalTraits;
using CompendiumLibrary;
using CompendiumLibrary.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.LinkLabel;
using System.Reflection.Emit;
using System.Diagnostics;

namespace CompendiumUI.Classes
{
    public partial class ClassViewerForm : Form
    {
        public ClassViewerForm()
        {
            InitializeComponent();

            ClassModel classModel = CreateClassTestModel();
            PopulateDataGridView(classModel);
            ClassTableGridView.Height = 528;
            this.AutoSize = false;

            this.Text = classModel.GetName();
            PopulateClassInformation(classModel);
            this.AutoScroll = true;

            this.Resize += ClassViewerForm_Resize;
        }
        private void ClassViewerForm_Resize(object sender, EventArgs e)
        {
            // Handle form resize event to update the TextBox height
            SetTextBoxHeightBasedOnText(ClassBaseStructure1);
        }

        private void PopulateDataGridView(ClassModel classModel)
        {

            // Assuming dataGridView1 is the name of your DataGridView control
            ClassTableGridView.Rows.Clear();
            ClassTableGridView.Columns.Clear(); // Clear existing columns

            // Add the default columns
            ClassTableGridView.Columns.Add("Level", "Level");
            ClassTableGridView.Columns.Add("ProficiencyBonus", "Proficiency Bonus");
            ClassTableGridView.Columns.Add("Features", "Features");
            if (classModel.HasSpellCastingCheck())
                ClassTableGridView.Columns.Add("Spellcasting", "Spellcasting");
            // Add custom sources dynamically
            List<ScalingModel> scalings = classModel.GetScalings();
            if (scalings != null && scalings.Count > 0)
            {
                AddCustomScalingColumns(scalings);
            }

            Dictionary<int, List<ClassFeatureModel>> features = classModel.GetFeatures();
            SpellCastingModel spellCastingModel = classModel.GetSpellCasting();

            // Populate the DataGridView
            for (int level = 1; level <= 20; level++)
            {
                int proficiencyBonus = GetProficiencyBonus(level);
                List<string> featureNames = new List<string>();
                if (features.TryGetValue(level, out List<ClassFeatureModel> featureList) && featureList != null)
                {
                    featureNames = featureList.Select(feature => feature.Name).ToList();
                }
                string featureString;
                if (featureNames == null)
                {
                    featureString = "-";
                }
                else
                {
                    featureString = string.Join(", ", featureNames);
                }


                string spellcasting = spellCastingModel.GetSpellSlots(level);

                object[] rowData;
                // Add data for default columns
                if (classModel.HasSpellCastingCheck())
                {
                    rowData = new object[] { level, proficiencyBonus, featureString, spellcasting };
                }
                else
                {
                    rowData = new object[] { level, proficiencyBonus, featureString };
                }

                if (scalings != null && scalings.Count > 0)
                {
                    // Add data for custom sources
                    rowData = rowData.Concat(GetCustomScalingData(scalings, level)).ToArray();
                }
                // Add a new row with all data
                ClassTableGridView.Rows.Add(rowData);
            }
            int totalHeight = ClassTableGridView.ColumnHeadersHeight;

            ClassTableGridView.AllowUserToAddRows = false;
            ClassTableGridView.BorderStyle = BorderStyle.None;

            ClassTableGridView.AutoSize = false;
            ClassTableGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        private void AddCustomScalingColumns(List<ScalingModel> Scalings)
        {

            // Add columns for each custom scaling
            foreach (ScalingModel scaling in Scalings)
            {
                ClassTableGridView.Columns.Add(scaling.Name, scaling.Name);

            }
        }

        private object[] GetCustomScalingData(List<ScalingModel> scalings, int level)
        {
            object[] data = new object[scalings.Count];
            for (int i = 0; i < data.Length; i++)
            {
                object currentData = scalings[i].GetScaling()[level];
                if (currentData == null)
                {

                    data[i] = "-";
                }
                else
                {
                    data[i] = currentData;
                }
            }
            return data;
        }

        private int GetProficiencyBonus(int level)
        {
            return level switch
            {
                1 or 2 or 3 or 4 => 2,
                5 or 6 or 7 or 8 => 3,
                9 or 10 or 11 or 12 => 4,
                13 or 14 or 15 or 16 => 5,
                17 or 18 or 19 or 20 => 6,
                _ => throw new IndexOutOfRangeException(),
            };
        }



        private void PopulateClassInformation(ClassModel classModel)
        {
            // Set the location of the label below the DataGridView
            ClassViewerName.Location = new Point(ClassTableGridView.Left, ClassTableGridView.Bottom + 10);
            ClassViewerName.Top = ClassTableGridView.Bottom + 10;
            ClassViewerName.Text = classModel.GetName();

            ClassBaseStructure1.Location = new System.Drawing.Point(ClassViewerName.Left, ClassViewerName.Bottom + 10);
            ClassBaseStructure1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            ClassBaseStructure1.Multiline = true;
            ClassBaseStructure1.WordWrap = true;
            ClassBaseStructure1.AutoSize = true;
            string descriptiontext = "As a " + classModel.GetName() + ", you gain the following class features."+
                "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            string formattedText = descriptiontext.Replace("\n", "\r\n");
            ClassBaseStructure1.Text = formattedText;
            ClassBaseStructure1.BorderStyle = BorderStyle.None;

            SetTextBoxHeightBasedOnText(ClassBaseStructure1);
            ClassBaseStructure1.ScrollBars = ScrollBars.None;
        }

        private void SetTextBoxHeightBasedOnText(System.Windows.Forms.TextBox textBox)
        {
            int textWidth = this.Width - (textBox.Padding.Left + textBox.Padding.Right);
            int lineCount = GetLineCount(textBox.Text, textBox.Font, textWidth) + 1;

            // Calculate the new height based on the number of lines
            int lineHeight = TextRenderer.MeasureText("SampleText", textBox.Font).Height; // Get the height of a single line
            int newHeight = lineHeight * lineCount;

            // Set the TextBox height to the new height
            textBox.Height = newHeight + 7;
        }

        private int GetLineCount(string text, Font font, int width)
        {
            // Calculate the number of lines based on the text, font, and width
            Size textSize = TextRenderer.MeasureText(text, font, new Size(width, int.MaxValue), TextFormatFlags.WordBreak);
            return textSize.Height / font.Height;
        }

        //Testing Model
        private ClassModel CreateClassTestModel()
        {
            List<Skill> SkillsList = new List<Skill>();
            SkillsList.Add(Skill.Arcana); SkillsList.Add(Skill.History); SkillsList.Add(Skill.Insight);
            SkillsList.Add(Skill.Investigation); SkillsList.Add(Skill.Medicine); SkillsList.Add(Skill.Religion);
            List<Abilities> AbilitiesList = new List<Abilities>();
            AbilitiesList.Add(Abilities.Intelligence); AbilitiesList.Add(Abilities.Wisdom);
            List<WeaponTypeModel> Weapons = new List<WeaponTypeModel>();
            Weapons.Add(new WeaponTypeModel("Dagger", 0, ""));
            Weapons.Add(new WeaponTypeModel("Dart", 0, ""));
            Weapons.Add(new WeaponTypeModel("Sling", 0, ""));
            Weapons.Add(new WeaponTypeModel("QuarterStaff", 0, ""));
            Weapons.Add(new WeaponTypeModel("Crossbows", 0, ""));
            ProficiencyModel proficiencyModel = new ProficiencyModel(true, 2, SkillsList, false, 0, AbilitiesList,
                null, Weapons, null, null, null);
            List<List<string>> equipmentOptions = new List<List<string>>
            {
                new List<string> { "(a) a quarterstaff", "(b) a dagger" },
                new List<string> { "(a) a component pouch", "(b) an arcane focus" },
                new List<string> { "(a) a scholar's pack", "(b) an explorer's pack" },
                new List<string> { "A spellbook" }
            };

            Dictionary<int, List<ClassFeatureModel>> features = new Dictionary<int, List<ClassFeatureModel>>
            {
                { 1, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Spellcasting", 1, "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.\r\n\r\nCantrips\r\nAt 1st level, you know three cantrips of your choice from the wizard spell list. You learn additional wizard cantrips of your choice at higher levels, as shown in the Cantrips Known column of the Wizard table.\r\n\r\nSpellbook\r\nAt 1st level, you have a spellbook containing six 1st-level wizard spells of your choice. Your spellbook is the repository of the wizard spells you know, except your cantrips, which are fixed in your mind.\r\n\r\nThe spells that you add to your spellbook as you gain levels reflect the arcane research you conduct on your own, as well as intellectual breakthroughs you have had about the nature of the multiverse. You might find other spells during your adventures. You could discover a spell recorded on a scroll in an evil wizard's chest, for example, or in a dusty tome in an ancient library.\r\n\r\nCopying a Spell into the Book. When you find a wizard spell of 1st level or higher, you can add it to your spellbook if it is of a spell level you can prepare and if you can spare the time to decipher and copy it.\r\n\r\nCopying a spell into your spellbook involves reproducing the basic form of the spell, then deciphering the unique system of notation used by the wizard who wrote it. You must practice the spell until you understand the sounds or gestures required, then transcribe it into your spellbook using your own notation.\r\n\r\nFor each level of the spell, the process takes 2 hours and costs 50 gp. The cost represents material components you expend as you experiment with the spell to master it, as well as the fine inks you need to record it. Once you have spent this time and money, you can prepare the spell just like your other spells.\r\n\r\nReplacing the Book. You can copy a spell from your own spellbook into another book-for example, if you want to make a backup copy of your spellbook. This is just like copying a new spell into your spellbook, but faster and easier, since you understand your own notation and already know how to cast the spell. You need spend only 1 hour and 10 gp for each level of the copied spell.\r\n\r\nIf you lose your spellbook, you can use the same procedure to transcribe the spells that you have prepared into a new spellbook. Filling out the remainder of your spellbook requires you to find new spells to do so, as normal. For this reason, many wizards keep backup spellbooks in a safe place.\r\n\r\nThe Book's Appearance. Your spellbook is a unique compilation of spells, with its own decorative flourishes and margin notes. It might be a plain, functional leather volume that you received as a gift from your master, a finely bound gilt-edged tome you found in an ancient library or even a loose collection of notes scrounged together after you lost your previous spellbook in a mishap.\r\n\r\nPreparing and Casting Spells\r\nThe Wizard table shows how many spell slots you have to cast your wizard spells of 1st level and higher. To cast one of these spells, you must expend a slot of the spell's level or higher. You regain all expended spell slots when you finish a long rest.\r\n\r\nYou prepare the list of wizard spells that are available for you to cast. To do so, choose a number of wizard spells from your spellbook equal to your Intelligence modifier + your wizard level (minimum of one spell). The spells must be of a level for which you have spell slots.\r\n\r\nFor example, if you're a 3rd-level wizard, you have four 1st-level and two 2nd-level spell slots. With an Intelligence of 16, your list of prepared spells can include six spells of 1st or 2nd level, in any combination, chosen from your spellbook. If you prepare the 1st-level spell magic missile, you can cast it using a 1st-level or a 2nd-level slot. Casting the spell doesn't remove it from your list of prepared spells.\r\n\r\nYou can change your list of prepared spells when you finish a long rest. Preparing a new list of wizard spells requires time spent studying your spellbook and memorizing the incantations and gestures you must make to cast the spell: at least 1 minute per spell level for each spell on your list.\r\n\r\nSpellcasting Ability\r\nIntelligence is your spellcasting ability for your wizard spells, since you learn your spells through dedicated study and memorization. You use your Intelligence whenever a spell refers to your spellcasting ability. In addition, you use your Intelligence modifier when setting the saving throw DC for a wizard spell you cast and when making an attack roll with one.\r\n\r\nSpell save DC = 8 + your proficiency bonus + your Intelligence modifier\r\n\r\nSpell attack modifier = your proficiency bonus + your Intelligence modifier\r\n\r\nRitual Casting\r\nYou can cast a wizard spell as a ritual if that spell has the ritual tag and you have the spell in your spellbook. You don't need to have the spell prepared.\r\n\r\nSpellcasting Focus\r\nYou can use an arcane focus as a spellcasting focus for your wizard spells.\r\n\r\nLearning Spells of 1st Level and Higher\r\nEach time you gain a wizard level, you can add two wizard spells of your choice to your spellbook. Each of these spells must be of a level for which you have spell slots, as shown on the Wizard table. On your adventures, you might find other spells that you can add to your spellbook."),
                    new ClassFeatureModel("Arcane Recovery", 2, "You have learned to regain some of your magical energy by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none of the slots can be 6th level or higher.\r\n\r\nFor example, if you're a 4th-level wizard, you can recover up to two levels worth of spell slots. You can recover either a 2nd-level spell slot or two 1st-level spell slots.")
                }},
                { 2, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Arcane Tradition", 3, "When you reach 2nd level, you choose an arcane tradition, shaping your practice of magic through one of the following schools. Your choice grants you features at 2nd level and again at 6th, 10th, and 14th level.")
                }},
                { 3, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Cantrip Formulas (Optional)", 4, "At 3rd level, you have scribed a set of arcane formulas in your spellbook that you can use to formulate a cantrip in your mind. Whenever you finish a long rest and consult those formulas in your spellbook, you can replace one wizard cantrip you know with another cantrip from the wizard spell list.")
                }},
                { 4, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Ability Score Improvement", 5, "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.")
                }},
                { 8, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Ability Score Improvement", 6, "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.")
                }},
                { 12, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Ability Score Improvement", 7, "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.")
                }},
                { 16, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Ability Score Improvement", 8, "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.")
                }},
                { 18, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Spell Mastery", 9, "At 18th level, you have achieved such mastery over certain spells that you can cast them at will. Choose a 1st-level wizard spell and a 2nd-level wizard spell that are in your spellbook. You can cast those spells at their lowest level without expending a spell slot when you have them prepared. If you want to cast either spell at a higher level, you must expend a spell slot as normal.\r\n\r\nBy spending 8 hours in study, you can exchange one or both of the spells you chose for different spells of the same levels.")
                }},
                { 19, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Ability Score Improvement", 10, "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.")
                }},
                { 20, new List<ClassFeatureModel> {
                    new ClassFeatureModel("Signature Spells", 11, "When you reach 20th level, you gain mastery over two powerful spells and can cast them with little effort. Choose two 3rd-level wizard spells in your spellbook as your signature spells. You always have these spells prepared, they don't count against the number of spells you have prepared, and you can cast each of them once at 3rd level without expending a spell slot. When you do so, you can't do so again until you finish a short or long rest.\r\n\r\nIf you want to cast either spell at a higher level, you must expend a spell slot as normal.")
                }},
            };
            SpellCastingModel spellCasting = new SpellCastingModel(
                "Spellcasting", 1, false, // Example: Not pact magic
                new Dictionary<int, int[]>
                { ///Spell Slots
                { 1, new int[] { 2, 0, 0, 0, 0, 0, 0, 0, 0 } },
                { 2, new int[] { 3, 0, 0, 0, 0, 0, 0, 0, 0 } },
                { 3, new int[] { 4, 2, 0, 0, 0, 0, 0, 0, 0 } },
                { 4, new int[] { 4, 3, 0, 0, 0, 0, 0, 0, 0 } },
                { 5, new int[] { 4, 3, 2, 0, 0, 0, 0, 0, 0 } },
                { 6, new int[] { 4, 3, 3, 0, 0, 0, 0, 0, 0 } },
                { 7, new int[] { 4, 3, 3, 1, 0, 0, 0, 0, 0 } },
                { 8, new int[] { 4, 3, 3, 2, 0, 0, 0, 0, 0 } },
                { 9, new int[] { 4, 3, 3, 3, 1, 0, 0, 0, 0 } },
                { 10, new int[] { 4, 3, 3, 3, 2, 0, 0, 0, 0 } },
                { 11, new int[] { 4, 3, 3, 3, 2, 1, 0, 0, 0 } },
                { 12, new int[] { 4, 3, 3, 3, 2, 1, 0, 0, 0 } },
                { 13, new int[] { 4, 3, 3, 3, 2, 1, 1, 0, 0 } },
                { 14, new int[] { 4, 3, 3, 3, 2, 1, 1, 0, 0 } },
                { 15, new int[] { 4, 3, 3, 3, 2, 1, 1, 1, 0 } },
                { 16, new int[] { 4, 3, 3, 3, 2, 1, 1, 1, 0 } },
                { 17, new int[] { 4, 3, 3, 3, 2, 1, 1, 1, 1 } },
                { 18, new int[] { 4, 3, 3, 3, 3, 1, 1, 1, 1 } },
                { 19, new int[] { 4, 3, 3, 3, 3, 2, 1, 1, 1 } },
                { 20, new int[] { 4, 3, 3, 3, 3, 2, 2, 1, 1 } },

                },
                new Dictionary<int, int>
                { // Cantrips known
                { 1, 3 },
                { 2, 3 },
                { 3, 3 },
                { 4, 4 },
                { 5, 4 },
                { 6, 4 },
                { 7, 4 },
                { 8, 4 },
                { 9, 4 },
                { 10, 5 },
                { 11, 5 },
                { 12, 5 },
                { 13, 5 },
                { 14, 5 },
                { 15, 5 },
                { 16, 5 },
                { 17, 5 },
                { 18, 5 },
                { 19, 5 },
                { 20, 5 },
                },
                null
            );
            //public ClassModel(string name, Source source, int classId, string hitDice,

            //    ProficiencyModel prof, MulticlassModel multiClass, List<int> subclassLevels,
            //    List<SubclassModel> subclasses, List<int> compendiums, List<List<string>> equipment,
            //    Dictionary<int, List<ClassFeatureModel>> features, bool hasSpellCasting,
            //    SpellCastingModel spellCasting, Dictionary<int, List<SpellModel>> spellList,
            //    List<ScalingModel> scalings, string description)
            //{
            ClassModel Testing = new ClassModel("Wizard", null, 0, "1d6", proficiencyModel, null,
            new List<int> { 2, 6, 10, 14 }, null, null, equipmentOptions, features,
            true, spellCasting, null, null, "Wizards are supreme magic-users, defined and united as a class by the spells they cast. Drawing on the subtle weave of magic that permeates the cosmos, wizards cast spells of explosive fire, arcing lightning, subtle deception, brute-force mind control, and much more.");
            return Testing;
        }
    }
}
