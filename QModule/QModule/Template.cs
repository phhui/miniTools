using System;
using System.IO;
using QModule.template;

namespace QModule
{
    class Template
    {
        public static string type;
        public static string eg = "egret";
        public static string cc = "cocos";
        public static string tmp = "temp";
        public static string outputPath = "";
        public static string[] tmpList = new string[5] { "template/Pq_TemplateCmd.ts", "template/Pq_TemplateMgr.ts", "template/Pq_TemplateCtl.ts", "template/Pq_TemplateUi.ts", "template/Pq_TemplateProxy.ts" };
        private static string[] tempList = new string[5];
        private static Boolean tempInited = false;
        public static void initTemplate()
        {
            if (tempInited) return;
            tempInited = true;
            if (File.Exists(tmpList[0])) tempList[0] = File.ReadAllText(tmpList[0]);
            else tempList[0] = Template.cmd;
            if (File.Exists(tmpList[1])) tempList[1] = File.ReadAllText(tmpList[1]);
            else tempList[1] = Template.mgr;
            if (File.Exists(tmpList[2])) tempList[2] = File.ReadAllText(tmpList[2]);
            else tempList[2] = Template.ctl;
            if (File.Exists(tmpList[3])) tempList[3] = File.ReadAllText(tmpList[3]);
            else tempList[3] = Template.ui;
            if (File.Exists(tmpList[4])) tempList[4] = File.ReadAllText(tmpList[4]);
            else tempList[4] = Template.proxy;
            if (File.Exists("template/output.txt"))
            {
                outputPath = File.ReadAllText("template/output.txt");
                if (!outputPath.Substring(outputPath.Length - 1).Equals("/")) outputPath += "/";
            }
        }
        public static String cmd{
            get
            {
                if (type.ToLower() == eg) return Egret.cmd;
                else if(type.ToLower()==cc)return Cocos.cmd;
                return tempList[0];
            }
        }
        public static String ctl{
            get
            {
                if (type.ToLower() == eg) return Egret.controll;
                else if (type.ToLower() == cc) return Cocos.controll;
                return tempList[2];
            }
        }
        public static String mgr{
            get
            {
                if (type.ToLower() == eg) return Egret.mgr;
                else if (type.ToLower() == cc) return Cocos.mgr;
                return tempList[1];
            }
        }
        public static String proxy
        {
            get
            {
                if (type.ToLower() == eg) return Egret.proxy;
                else if (type.ToLower() == cc) return Cocos.proxy;
                return tempList[4];
            }
        }
        public static String ui
        {
            get
            {
                if (type.ToString() == eg) return Egret.ui;
                else if (type.ToLower() == cc) return Cocos.ui;
                return tempList[3];
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
