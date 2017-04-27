using System;
using EloBuddy;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Janna___Unwake_s_Fury
{
    class DrawingManager
    {
        public static void Drawing_OnDraw(EventArgs args)
        {
            if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "qRange"))
            {
                if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "onlyRdy"))
                {
                    if (SpellsManager.Q.IsReady())
                        Circle.Draw(Color.Chartreuse, SpellsManager.Q.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, SpellsManager.Q.Range, Player.Instance.Position);
                }
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "wRange"))
            {
                if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "onlyRdy"))
                {
                    if (SpellsManager.W.IsReady())
                        Circle.Draw(Color.Chartreuse, SpellsManager.W.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, SpellsManager.W.Range, Player.Instance.Position);
                }
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "eRange"))
            {
                if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "onlyRdy"))
                {
                    if (SpellsManager.E.IsReady())
                        Circle.Draw(Color.Chartreuse, SpellsManager.E.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, SpellsManager.E.Range, Player.Instance.Position);
                }
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "rRange"))
            {
                if (MenuManager.GetCheckBoxItem(MenuManager.DrawMenu, "onlyRdy"))
                {
                    if (SpellsManager.R.IsReady())
                        Circle.Draw(Color.Chartreuse, SpellsManager.R.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, SpellsManager.R.Range, Player.Instance.Position);
                }
            }
        }
    }
}
