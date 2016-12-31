using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using static Jinx_Template.Program;
using static Jinx_Template.Menus;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    class Combo
    {
        public static void ComboExecute()
        {
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Physical);

            if ((target == null) || target.IsInvulnerable) return;

            if (ComboMenu["Q"].Cast<CheckBox>().CurrentValue)
            {
                if (target.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    Spells.Q.Cast(target);
                }
            }

            if (ComboMenu["W"].Cast<CheckBox>().CurrentValue)
            {
                if (target.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    var whitchance = Spells.W.GetPrediction(target);
                    if (whitchance.HitChancePercent >= 80)
                    {
                        Spells.W.Cast(target);
                    }

                }
            }

            if (ComboMenu["E"].Cast<CheckBox>().CurrentValue)
            {
                if (target.IsValidTarget(Spells.E.Range) && Spells.Q.IsReady())
                {
                    var ehitchance = Spells.E.GetPrediction(target);
                    if (ehitchance.HitChancePercent >= 80)
                    {
                        Spells.E.Cast(target);
                    }

                }
            }

            if (ComboMenu["R"].Cast<CheckBox>().CurrentValue)
            {
                var enemy = EntityManager.Heroes.Enemies.FirstOrDefault(x => x.IsValidTarget(Spells.R.Range) && x.IsValid);


                if (target.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    var rhitchance = Spells.R.GetPrediction(target);
                    if (rhitchance.HitChancePercent >= 80)
                    {
                        Spells.R.Cast(target);
                    }

                }
            }

        }
    }
}
