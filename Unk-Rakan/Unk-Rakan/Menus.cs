using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Unk_Rakan
{
    class Menus
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

        public static Menu RakanMain, DrawMenu, ComboMenu, HarassMenu, InterrupterMenu, FleeMenu, MiscMenu;

        public static void CreateMenu()
        {
            RakanMain = MainMenu.AddMenu("Unk Rakan", "rakMenu");
            RakanMain.AddLabel(Program.Version);
            RakanMain.AddLabel("Made by Unwake");

            ComboMenu = RakanMain.AddSubMenu("Combo");
            ComboMenu.AddLabel("Select your Combo Type");
            ComboMenu.Add("Combo QWR", new CheckBox("Combo QWR", true));
            ComboMenu.Add("Combo WQE", new CheckBox("Combo WQE", false));
            ComboMenu.Add("Combo EWQE", new CheckBox("Combo EWQE", false));
            ComboMenu.Add("Combo REWQE", new CheckBox("Combo REWQE", false));
            ComboMenu.AddSeparator(0);
            ComboMenu.Add("Use Q", new CheckBox("Use Q", true));
            ComboMenu.Add("Use W", new CheckBox("Use W", true));
            ComboMenu.Add("Use E", new CheckBox("Use E", true));
            ComboMenu.Add("Use R", new CheckBox("Use R", true));
            ComboMenu.Add("Use R in Min Enemies", new Slider("Min Enemies R", 2, 1, 5));
            ComboMenu.AddSeparator(0);
            ComboMenu.Add("Use Ignite", new CheckBox("Use Ignite", true));

            HarassMenu = RakanMain.AddSubMenu("Harass");
            HarassMenu.Add("Use Q", new CheckBox("Use Q", true));
            HarassMenu.Add("Use Q Mana Percent", new Slider("Min Mana %", 30, 1, 100));
            HarassMenu.AddSeparator(0);
            HarassMenu.Add("Use AutoQ", new CheckBox("Use Auto Q", true));
            HarassMenu.Add("Use AutoQ Mana Percent", new Slider("Min Mana Auto Q %", 30, 1, 100));

            InterrupterMenu = RakanMain.AddSubMenu("Interrupter");
            InterrupterMenu.Add("Use W", new CheckBox("Use W", true));

            FleeMenu = RakanMain.AddSubMenu("Flee");
            FleeMenu.Add("AutoE", new CheckBox("Use E", true));
            FleeMenu.Add("AutoEManaCost", new Slider("Mana E %", 30, 1, 100));
            FleeMenu.AddSeparator(0);
            FleeMenu.Add("AutoRFlee", new CheckBox("Use R To Escape", true));
            FleeMenu.Add("AutoRHpPer", new Slider("HP Percent to Use Auto R %", 25, 1, 100));

            MiscMenu = RakanMain.AddSubMenu("Misc");
            MiscMenu.Add("WGap", new CheckBox("Use W on GapCloser", true));
            MiscMenu.AddSeparator(0);
            MiscMenu.Add("AutoPot", new CheckBox("Use Auto Potion", true));
            MiscMenu.Add("AutoPotHPPercent", new Slider("Auto Pot HP %", 30, 1, 100));
            MiscMenu.AddSeparator(0);
            MiscMenu.Add("skinHack", new CheckBox("Skin Change", false));
            MiscMenu.Add("SkinID", new Slider("Skin", 0, 0, 1));

            DrawMenu = RakanMain.AddSubMenu("Drawings");
            DrawMenu.Add("qRange", new CheckBox("Draw Q", false));
            DrawMenu.Add("wRange", new CheckBox("Draw W", false));
            DrawMenu.Add("eRange", new CheckBox("Draw E", false));
            DrawMenu.Add("rRange", new CheckBox("Draw R", false));
            DrawMenu.AddSeparator(0);
            DrawMenu.Add("onlyRdy", new CheckBox("Draw when skill is Ready", true));

        }
    }
}
