﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace ReRyze.ConfigList
{
    public static class Combo
    {
        private static readonly Menu Menu;
        private static readonly CheckBox _ComboQ;
        private static readonly CheckBox _ComboW;
        private static readonly CheckBox _ComboE;
        private static readonly CheckBox _ComboWithoutW;
        private static readonly Slider _ComboLogic;

        public static bool ComboQ
        {
            get { return _ComboQ.CurrentValue; }
        }
        public static bool ComboW
        {
            get { return _ComboW.CurrentValue; }
        }
        public static bool ComboE
        {
            get { return _ComboE.CurrentValue; }
        }
        public static bool ComboWithoutW
        {
            get { return _ComboWithoutW.CurrentValue; }
        }
        public static int GetComboLogic
        {
            get { return _ComboLogic.CurrentValue; }
        }

        static Combo()
        {
            Menu = Config.Menu.AddSubMenu("Combo");
            Menu.AddGroupLabel("Combo settings");
            _ComboQ = Menu.Add("ComboQ", new CheckBox("Use Q in combo"));
            _ComboW = Menu.Add("ComboW", new CheckBox("Use W in combo"));
            _ComboE = Menu.Add("ComboE", new CheckBox("Use E in combo"));
            _ComboWithoutW = Menu.Add("ComboWithoutW", new CheckBox("Allow to skip W."));
            _ComboLogic = Menu.Add("ComboLogic", new Slider("Select logic [QEQWQEQE] / [QEEQWQEQ]", 0, 0, 1));
        }

        public static void Initialize()
        {
        }
    }
}