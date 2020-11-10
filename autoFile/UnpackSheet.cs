using System;
using System.Windows.Forms;

namespace ppqq
{
    public partial class UnpackSheet : Form
    {
        public UnpackSheet()
        {
            InitializeComponent();
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            /*string[] url = new string[] { "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/bidaxiao.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/buyudaren.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/hongbaosaolei.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/danaotiangong.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/dezhou.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/doudizhu.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/erbagan.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/errenmajiang.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/erzhangpai.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/feiqinzoushou.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/haochejulebu.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/jincangbuyu.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/kuaile30miao.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/kuaile5zhang.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/likuipiyu.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/longhudazhan.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/sanzhangpai.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/tongbiniuniu.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/toubao.png",
                                            "D:/wk/h5/chess/chess-pro/resource/res/gameIcon/xunlongduobao.png",
                                            };*/
            string list = tb_list.Text.Replace("\r\n", "|");
            string[] url = list.Split('|');
            for (int i = 0; i < url.Length; i++)
            {
                var unpacker = new Unpacker();
                unpacker.Unpack(url[i]);
            }
            MessageBox.Show("切图完成！");
        }

        private void UnpackSheet_Load(object sender, EventArgs e)
        {
            tb_list.Text = "输入图片地址，一行一个";
        }
    }
}
