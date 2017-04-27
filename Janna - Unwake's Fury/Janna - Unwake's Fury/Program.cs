using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;

namespace Janna___Unwake_s_Fury
{
    class Program
    {
        public static string Version = "Version 1.0.0.0";
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.ChampionName != "Janna")
            {
                return;
            }

            MenuManager.CreateMenu();
            Drawing.OnDraw += DrawingManager.Drawing_OnDraw;
            Game.OnTick += Game_OnTick;
            Game.OnUpdate += Game_OnGameUpdate;
            Interrupter.OnInterruptableSpell += Interrupter_OnInterruptableSpell;
            Gapcloser.OnGapcloser += GapCloser_OnGapCloser;

            Chat.Print("Janna - Unwake's Fury - Loaded Succesfully");
            Chat.Print("Please report any issues in the thread.");

        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (MenuManager.GetCheckBoxItem(MenuManager.MiscMenu, "skinHack"))
            {
                Player.Instance.SetSkinId(MenuManager.GetSliderItem(MenuManager.MiscMenu, "SkinID"));
            }

            else
            {
                Player.Instance.SetSkinId(0);
            }

            MiscManager.AutoHeal();
            MiscManager.AutoShield();

        }

        private static void Game_OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.Equals(Orbwalker.ActiveModes.Combo))
                ComboManager.Combo();

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee))
                FleeManager.Flee();
                MiscManager.AutoPotion();
        }

        public static void GapCloser_OnGapCloser(Obj_AI_Base sender, Gapcloser.GapcloserEventArgs args)
        {
            if (sender.IsEnemy && sender is AIHeroClient && sender.Distance(ObjectManager.Player) < SpellsManager.Q.Range && SpellsManager.Q.IsReady() &&
                MenuManager.GetCheckBoxItem(MenuManager.MiscMenu, "Use Q"))
            {
                SpellsManager.Q.Cast(sender);
            }
        }

        public static void Interrupter_OnInterruptableSpell(Obj_AI_Base sender,
            Interrupter.InterruptableSpellEventArgs args)
        {
            if (args.DangerLevel == DangerLevel.High && sender != null && !sender.IsMe && sender.IsEnemy && sender is AIHeroClient && sender.Distance(ObjectManager.Player) < SpellsManager.Q.Range && SpellsManager.Q.IsReady() && MenuManager.GetCheckBoxItem(MenuManager.InterrupterMenu, "Use Q"))
            {
                SpellsManager.Q.Cast(sender);
            }
        }
    }
}
