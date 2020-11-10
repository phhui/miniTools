using System;
using System.Drawing;
using System.Windows.Forms;
namespace ppqq
{
    class Grid
    {
        private static int row = 0;
        private static int col = 0;
        private static int total = 0;
        private static Label[] lbList = new Label[99999];
        public static void createGrid(int w,int h,int size,Form f)
        {
            row = (int)Math.Floor((double)f.Height/size);
            col = (int)Math.Floor((double)f.Width / size);
            int n = 0;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    n = i * col + j;
                    if (lbList[n] == null || lbList[n].IsDisposed)
                    {
                        lbList[n] = new Label();
                        lbList[n].Click += new EventHandler(lbClick);
                    }
                    Label lb = lbList[n];
                    lb.BackColor = Color.White;
                    lb.Size = new Size(size,size);
                    lb.BackColor = Color.Transparent;
                    lb.Location = new Point(j*size,i*size);
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    f.Controls.Add(lb);
                }
            }

        }
        public static void lbClick(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = (lb.BackColor == Color.White ? Color.Black : Color.White);
        }
    }
}
