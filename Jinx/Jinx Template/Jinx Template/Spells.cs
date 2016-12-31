using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    internal static class Spells
    {
        public static Spell.Active Q;
        public static Spell.Skillshot W;
        public static Spell.Skillshot E;
        public static Spell.Skillshot R;

        public static void InitializeSpells()
        {
            Q = new Spell.Active(SpellSlot.Q, 600);
            W = new Spell.Skillshot(SpellSlot.W, 1450, SkillShotType.Linear);
            E = new Spell.Skillshot(SpellSlot.E, 900, SkillShotType.Linear);
            R = new Spell.Skillshot(SpellSlot.R, 2000, SkillShotType.Linear);
        }

    }
}
