using System;
using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinx_Template
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu ComboMenu;
        public static Menu DrawingsMenu;
        public static Menu LaneMenu;

        public static void CreateMenu()
        {
            //Press Shift Champion name + "Template" will show up
            FirstMenu = MainMenu.AddMenu(Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Template");

            ComboMenu = FirstMenu.AddSubMenu("Combo Menu");
            DrawingsMenu = FirstMenu.AddSubMenu("Drawings Menu");
            LaneMenu = FirstMenu.AddSubMenu("Lane Clear Menu");

            //Combo menu
            ComboMenu.AddGroupLabel("Combo Settings"); //Title
            ComboMenu.Add("Q",new CheckBox("Use Q"));
            ComboMenu.Add("W", new CheckBox("Use W"));
            ComboMenu.Add("E", new CheckBox("Use E"));
            ComboMenu.Add("R", new CheckBox("Use R"));
            ComboMenu.Add("REnemies", new Slider("Enemies in range to use R", 3, 1, 5));

            //Drawings menu
            ComboMenu.AddGroupLabel("Combo Settings"); //Title
            ComboMenu.Add("Q", new CheckBox("Draw Q"));
            ComboMenu.Add("W", new CheckBox("Draw W"));
            ComboMenu.Add("E", new CheckBox("Draw E"));
            ComboMenu.Add("R", new CheckBox("Draw R"));

            //LaneClear menu
            LaneMenu.AddGroupLabel("Lane Settings");
            LaneMenu.Add("Q", new CheckBox("Use Q"));
            LaneMenu.Add("MinManaQ", new Slider("Minimum Mana to Cast Q", 30, 1, 99));
        }
    }
}
