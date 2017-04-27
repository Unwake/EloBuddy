using System;
using EloBuddy;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Rakan___Unwake_s_Charmer
{
    class Drawings
    {
        public static void Drawing_OnDraw(EventArgs args)
        {
            if (Menus.GetCheckBoxItem(Menus.DrawMenu, "qRange"))
            {
                if (Menus.GetCheckBoxItem(Menus.DrawMenu, "onlyRdy"))
                {
                    if (Spells.Q.IsReady())
                        Circle.Draw(Color.Chartreuse, Spells.Q.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, Spells.Q.Range, Player.Instance.Position);
                }
            }

            if (Menus.GetCheckBoxItem(Menus.DrawMenu, "wRange"))
            {
                if (Menus.GetCheckBoxItem(Menus.DrawMenu, "onlyRdy"))
                {
                    if (Spells.W.IsReady())
                        Circle.Draw(Color.Chartreuse, Spells.W.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, Spells.W.Range, Player.Instance.Position);
                }
            }

            if (Menus.GetCheckBoxItem(Menus.DrawMenu, "eRange"))
            {
                if (Menus.GetCheckBoxItem(Menus.DrawMenu, "onlyRdy"))
                {
                    if (Spells.E.IsReady())
                        Circle.Draw(Color.Chartreuse, Spells.E.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, Spells.E.Range, Player.Instance.Position);
                }
            }

            if (Menus.GetCheckBoxItem(Menus.DrawMenu, "rRange"))
            {
                if (Menus.GetCheckBoxItem(Menus.DrawMenu, "onlyRdy"))
                {
                    if (Spells.R.IsReady())
                        Circle.Draw(Color.Chartreuse, Spells.R.Range, Player.Instance.Position);
                }

                else
                {
                    Circle.Draw(Color.Chartreuse, Spells.R.Range, Player.Instance.Position);
                }
            }
        }
    }
}
