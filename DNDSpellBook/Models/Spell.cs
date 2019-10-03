using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDSpellBook.Models
{
    public enum CastClass { Bard, Cleric, Druid, Paladin, Ranger, Ritual_Caster, Sorcerer, Warlock, Wizard }
    public enum CastSchool { Abjuration, Conjuration, Divination, Enchantment, Evocation, Necromancy, Telemancy, NONE }

    public class SpellRAW
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Higher_Level { get; set; }
        public string Page { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Materials { get; set; }
        public string Ritual { get; set; }
        public string Duration { get; set; }
        public string Concentration { get; set; }
        public string Casting_Time { get; set; }
        public string Level { get; set; }
        public string School { get; set; }
        public string Class { get; set; }

    }

    public class Spell
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Higher_Level { get; set; }
        public string Page { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Materials { get; set; }
        public string Ritual { get; set; }
        public string Duration { get; set; }
        public string Concentration { get; set; }
        public string Casting_Time { get; set; }
        public int Level { get; set; }
        public CastSchool School { get; set; }
        public CastClass Class { get; set; }

        public Spell(SpellRAW spellRAW)
        {
            Name = spellRAW.Name;
            Desc = spellRAW.Desc;
            Higher_Level = spellRAW.Higher_Level;
            Page = spellRAW.Page;
            Range = spellRAW.Range;
            Components = spellRAW.Components;
            Materials = spellRAW.Materials;
            Ritual = spellRAW.Ritual;
            Duration = spellRAW.Duration;
            Concentration = spellRAW.Concentration;
            Casting_Time = spellRAW.Casting_Time;
            Level = ConvertToSpellLevel(spellRAW.Level);
            School = ConvertToSchool(spellRAW.School);
            Class = ConvertToClass(spellRAW.Class);
        }

        private CastSchool ConvertToSchool(string school)
        {
            CastSchool castSchool = CastSchool.NONE;

            foreach (var sch in Enum.GetValues(typeof(CastSchool)).Cast<CastSchool>())
            {
                if (sch.ToString() == school)
                {
                    castSchool = sch;
                }
            }

            return castSchool;
        }

        private CastClass ConvertToClass(string c)
        {
            throw new NotImplementedException();
        }

        private int ConvertToSpellLevel(string spellLevelString)
        {
            int spellLevelInt;

            if (spellLevelString.ToUpper().Contains("CANTRIP"))
            {
                spellLevelInt = 0;
            }
            else
            {
                if (int.TryParse(spellLevelString, out spellLevelInt))
                {

                }
                else
                {
                    spellLevelInt = -1;
                }
            }
            return spellLevelInt;

        }
    }
}
