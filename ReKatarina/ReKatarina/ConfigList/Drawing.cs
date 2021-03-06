﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace ReKatarina.ConfigList
{
    public static class Drawing
    {
        private static readonly Menu Menu;
        private static readonly CheckBox _drawQ;
        private static readonly CheckBox _drawW;
        private static readonly CheckBox _drawE;
        private static readonly CheckBox _drawR;
        private static readonly CheckBox _drawDI;
        private static readonly CheckBox _drawCJ;

        public static bool DrawQ
        {
            get { return _drawQ.CurrentValue; }
        }

        public static bool DrawW
        {
            get { return _drawW.CurrentValue; }
        }

        public static bool DrawE
        {
            get { return _drawE.CurrentValue; }
        }

        public static bool DrawR
        {
            get { return _drawR.CurrentValue; }
        }

        public static bool DrawDI
        {
            get { return _drawDI.CurrentValue; }
        }
        public static bool DrawCJ
        {
            get { return _drawCJ.CurrentValue; }
        }

        static Drawing()
        {
            Menu = Config.Menu.AddSubMenu("Drawing");
            Menu.AddGroupLabel("Drawing settings");
            _drawQ = Menu.Add("DrawQ", new CheckBox("Draw Q range"));
            _drawW = Menu.Add("DrawW", new CheckBox("Draw W range"));
            _drawE = Menu.Add("DrawE", new CheckBox("Draw E range"));
            _drawR = Menu.Add("DrawR", new CheckBox("Draw R range"));
            Menu.AddGroupLabel("Damage indicator");
            _drawDI = Menu.Add("DrawDI", new CheckBox("Draw Damage Indicator"));
            Menu.AddGroupLabel("Cursor jump range");
            _drawCJ = Menu.Add("DrawCJ", new CheckBox("Draw circle around mouse with range of flee / ward jump."));
        }

        public static void Initialize()
        {
        }
    }
}