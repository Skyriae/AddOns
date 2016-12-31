using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using static AddonName.Menus;
using static Jinx_Template.Program;
using static Jinx_Template.Menus;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    class LaneClear
    {
        public static void LaneExecute()
        {
            //Where lane monsters are
            var Qlanemonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.Q.Range);

            //Check if use q is checked AND spell is ready
            if (LaneMenu["Q"].Cast<CheckBox>().CurrentValue && Spells.Q.IsReady())
            {
                //Checks mana slider
                if ( Player.Instance.ManaPercent >= LaneMenu["MinManaQ"].Cast<Slider>().CurrentValue)
                {
                    foreach (var minion in Qlanemonster)
                    {
                        if (minion.IsValidTarget())
                        {
                            Spells.Q.Cast(minion);
                        }

                    }
                }

            }
        }
    }
}
