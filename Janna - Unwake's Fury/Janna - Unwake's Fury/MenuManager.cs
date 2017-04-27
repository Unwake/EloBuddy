using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Janna___Unwake_s_Fury
{
    class MenuManager
    {
        public static bool GetCheckBoxItem(Menu m, string item)
        {
            return m[item].Cast<CheckBox>().CurrentValue;
        }

        public static int GetSliderItem(Menu m, string item)
        {
            return m[item].Cast<Slider>().CurrentValue;
        }

        public static bool GetKeyBindItem(Menu m, string item)
        {
            return m[item].Cast<KeyBind>().CurrentValue;
        }

        public static int GetBoxItem(Menu m, string item)
        {
            return m[item].Cast<ComboBox>().CurrentValue;
        }

        public static Menu JannaMain, DrawMenu, ComboMenu, InterrupterMenu, FleeMenu, MiscMenu;

        public static void CreateMenu()
        {
            JannaMain = MainMenu.AddMenu("Janna - Unwake's Fury", "jmenu");
            JannaMain.AddLabel(Program.Version);
            JannaMain.AddLabel("Made by Unwake");

            ComboMenu = JannaMain.AddSubMenu("Combo");
            ComboMenu.Add("Use Q", new CheckBox("Use Q", true));
            ComboMenu.Add("Use W", new CheckBox("Use W", true));
            ComboMenu.Add("Use E", new CheckBox("Use E", true));
            ComboMenu.Add("UseEADC", new CheckBox("Use E ADC in Combo Mode", false));
            ComboMenu.AddSeparator(0);
            ComboMenu.Add("Use Ignite", new CheckBox("Use Ignite", false));

            InterrupterMenu = JannaMain.AddSubMenu("Interrupter");
            InterrupterMenu.Add("Use Q", new CheckBox("Use Q", true));

            FleeMenu = JannaMain.AddSubMenu("Flee");
            FleeMenu.Add("Use Q", new CheckBox("Use Q", true));
            FleeMenu.Add("Use W", new CheckBox("Use W", true));

            MiscMenu = JannaMain.AddSubMenu("Misc");
            MiscMenu.Add("Auto R", new CheckBox("Enable Auto R", true));
            MiscMenu.Add("AutoRHP", new Slider("Use Auto R if Ally HP %", 15, 1, 100));
            MiscMenu.Add("Auto E", new CheckBox("Enable Auto E", true));
            MiscMenu.Add("AutoEHP", new Slider("Use Auto E if Ally HP %", 15, 1, 100));
            MiscMenu.AddSeparator(0);
            MiscMenu.Add("QGap", new CheckBox("Use Q on GapClosers", true));
            MiscMenu.AddSeparator(0);
            MiscMenu.Add("AutoPot", new CheckBox("Use Auto Potion", true));
            MiscMenu.Add("AutoPotHP", new Slider("Auto Pot HP %", 30, 1, 100));
            MiscMenu.AddSeparator(0);
            MiscMenu.Add("skinHack", new CheckBox("Skin Change", false));
            MiscMenu.Add("SkinID", new Slider("Skin", 0, 0, 7));

            DrawMenu = JannaMain.AddSubMenu("Drawings");
            DrawMenu.Add("qRange", new CheckBox("Draw Q", false));
            DrawMenu.Add("wRange", new CheckBox("Draw W", false));
            DrawMenu.Add("eRange", new CheckBox("Draw E", false));
            DrawMenu.Add("rRange", new CheckBox("Draw R", false));
            DrawMenu.AddSeparator(0);
            DrawMenu.Add("onlyRdy", new CheckBox("Draw when skill is Ready", true));
        }
    }
}
