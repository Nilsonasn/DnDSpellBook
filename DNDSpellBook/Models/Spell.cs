using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDSpellBook.Models
{
    
    public enum CastSchool { Abjuration, Conjuration, Divination, Enchantment, Evocation, Necromancy, Telemancy, NONE }
    public enum CastLevel { Cantrip, First_Level, Second_Level, Third_Level, Fourth_Level, Fifth_Level, Sixth_Level, Seventh_Level, Eighth_Level, Ninth_Level}

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
        public CastLevel Level { get; set; }
        public CastSchool School { get; set; }
        public List<CastClass> Classes { get; set; }

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
            Classes = ConvertToClass(spellRAW.Class);
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

        public string LevelString()
        {
            return CastLevelToString(Level);
        }
        static public string IntToSpellString(int level)
        {
            return CastLevelToString((CastLevel)level);
        }
        static public string CastLevelToString(CastLevel level)
        {
            switch ((int)level)
            {
                case 0:
                    return "Cantrip";
                case 1:
                    return "1st Level";
                case 2:
                    return "2nd Level";
                case 3:
                    return "3rd Level";
                case 4:
                    return "4th level";
                case 5:
                    return "5th level";
                case 6:
                    return "6th level";
                case 7:
                    return "7th level";
                case 8:
                    return "8th level";
                case 9:
                    return "9th level";
                default:
                    return "none";
            }
        }

        private List<CastClass> ConvertToClass(string c)
        {
            string classString = c;
            List<CastClass> castClasses = new List<CastClass>();
            foreach (var cls in Enum.GetValues(typeof(CastClass)).Cast<CastClass>())
            {
                if (classString.ToUpper().Contains(cls.ToString().ToUpper())){
                    castClasses.Add(cls);
                }
            }
            return castClasses;
        }

        private CastLevel ConvertToSpellLevel(string spellLevelString)
        {
            int spellLevelInt;

            if (spellLevelString.ToUpper().Contains("CANTRIP"))
            {
                spellLevelInt = 0;
            }
            else
            {
                if (int.TryParse(spellLevelString.Substring(0,1), out spellLevelInt))
                {

                }
                else
                {
                    spellLevelInt = -1;
                }
            }
            return (CastLevel)spellLevelInt;

        }
        public static List<Spell> ConvertRawSpells(List<SpellRAW> rawSpells)
        {
            List<Spell> spells = new List<Spell>();
            foreach(SpellRAW rawSp in rawSpells)
            {
                spells.Add(new Spell(rawSp));
            }
            return spells;
        }
    }
}
