using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDSpellBook.Models
{
    public enum CastClass { Bard, Cleric, Druid, Paladin, Ranger, Ritual_Caster, Sorcerer, Warlock, Wizard }
    public class CasterClass
    {
        public CastClass CasterName { get; set; }
        public List<Spell> ClassSpells { get; set; }

        public CasterClass(CastClass casterClass,  List<Spell> spellList)
        {
            CasterName = casterClass;
            ClassSpells = spellList.Where(x => x.Classes.Contains(casterClass)).ToList();
        }

    }
}
