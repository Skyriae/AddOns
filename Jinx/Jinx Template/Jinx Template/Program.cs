using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using static Jinx_Template.Combo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Jinx) return;

            //Chat.Print("Hello");
            //Game.OnUpdate += OnUpdate; //Faster Reaction
            Game.OnTick += OnTick; // More Fps
            Menus.CreateMenu();
            Spells.InitializeSpells();
            Drawings.CreateDrawings();
        }

        private static void OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ComboExecute();
        }
    }
}
