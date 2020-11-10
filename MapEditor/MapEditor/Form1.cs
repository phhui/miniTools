using ppqq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        private int size = 30;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //createThread(updateGrid);
            updateGrid();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileDetails fd = new FileDetails(files[0]);
                if (fd.type.Equals(".jpg")) this.BackgroundImage = Image.FromFile(fd.fullName);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //createThread(updateGrid);
            updateGrid();
        }
        private void updateGrid()
        {
            Grid.createGrid(this.Width, this.Height, size, this);
        }
        private Thread createThread(ThreadStart ts)
        {
            Thread th = new Thread(ts);
            th.Start();
            return th;
        }
    }
}
