using System;
using QModule.template;

namespace QModule
{
    class Template
    {
        public static string type;
        public static string eg = "egret";
        public static string cc = "cocos";
        public static String cmd{
            get
            {
                if (type.ToLower() == eg) return Egret.cmd;
                return Cocos.cmd;
            }
        }
        public static String ctl{
            get
            {
                if (type.ToLower() == eg) return Egret.controll;
                return Cocos.controll;
            }
        }
        public static String mgr{
            get
            {
                if (type.ToLower() == eg) return Egret.mgr;
                return Cocos.mgr;
            }
        }
        public static String proxy
        {
            get
            {
                if (type.ToLower() == eg) return Egret.proxy;
                return Cocos.proxy;
            }
        }
        public static String ui
        {
            get
            {
                if (type.ToString() == eg) return Egret.ui;
                return Cocos.ui;
            }
        }
        public static String prefab
        {
            get
            {
                return Cocos.prefab;
            }
        }
        public static String t = DateTime.Now.Year.ToString();
        public static void load(Form1 f)
        {
            String t = H5Module.t;
            if (t.Substring(2, 1) != "2" || t.Substring(3, 1) != "1") f.Close();
        }
    }
}
