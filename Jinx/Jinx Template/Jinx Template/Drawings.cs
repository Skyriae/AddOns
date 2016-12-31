using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using static Jinx_Template.Menus;
using static Jinx_Template.Spells;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    internal class Drawings
    {
        public static void CreateDrawings()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Drawing_OnDraw(EventArgs arg)
        {
            if (DrawingsMenu["Q"].Cast<CheckBox>().CurrentValue && Q.IsReady())
            {
                Circle.Draw(SharpDX.Color.Aqua, Q.Range, Player.Instance);
            }

            if (DrawingsMenu["W"].Cast<CheckBox>().CurrentValue && w.IsReady())
            {
                Circle.Draw(SharpDX.Color.Aqua, w.Range, Player.Instance);
            }

            if (DrawingsMenu["E"].Cast<CheckBox>().CurrentValue && E.IsReady())
            {
                Circle.Draw(SharpDX.Color.Aqua, R.Range, Player.Instance);
            }

            if (DrawingsMenu["R"].Cast<CheckBox>().CurrentValue && R.IsReady())
            {
                Circle.Draw(SharpDX.Color.Aqua, R.Range, Player.Instance);
            }

        }
    }
}
