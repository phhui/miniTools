using System;
using System.IO;
using System.Windows.Forms;

namespace autoRspd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String ct = File.ReadAllText("E:/h5/Client/src/com/kynet/protocols/MsgId.ts");
            String reg = @"class RegRqst{
    constructor(){";
            String tmp = ct.Substring(ct.IndexOf("Rspd"));
            String cls = tmp.Substring(tmp.IndexOf("Rspd"), tmp.IndexOf(" "));
            reg += "\r\n        SocketMgr.regRspt(0,protocols." + cls + ");\r\n";
            while (tmp.IndexOf("Rspd") != -1 && tmp.IndexOf("SMSG") != -1)
            {
                tmp = tmp.Substring(tmp.IndexOf("SMSG"));
                String id = tmp.Substring(tmp.IndexOf("[") + 1, tmp.IndexOf("]") - tmp.IndexOf("[") - 1);
                tmp = tmp.Substring(tmp.IndexOf("Rspd"));
                cls = tmp.Substring(0, tmp.IndexOf(" "));
                if(id!="2007"&&id!="2008")reg += "        SocketMgr.regRspt(" + id + ",protocols." + cls + ");\r\n";
                tmp = tmp.Substring(100);
            }
            reg += @"  
    }
}";
            File.WriteAllText("", reg);
        }
    }
}
