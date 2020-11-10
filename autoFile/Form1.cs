using System;
using System.Windows.Forms;

namespace ppqq
{
    public partial class Form1 : Form
    {
        private string configPath = "conf/conf.txt";
        private FileMgr fm;
        private Sync sync;
        private H5 h5;
        private CheckFile cf;
        private Filter filter;
        private UnpackSheet sheet;
        //private 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFileMgr_Click(object sender, EventArgs e)
        {
            if (fm == null||fm.IsDisposed)
            {
                fm = new FileMgr();
            }
            fm.Show();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            if (sync == null || sync.IsDisposed)
            {
                sync = new Sync();
            }
            sync.Show();
        }

        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            if (h5 == null || h5.IsDisposed)
            {
                h5 = new H5();
            }
            h5.Show();
        }

        private void btnCheckRes_Click(object sender, EventArgs e)
        {
            if (cf == null || cf.IsDisposed)
            {
                cf = new CheckFile();
            }
            cf.Show();
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            if(filter==null|| filter.IsDisposed)
            {
                filter = new Filter();
            }
            filter.Show();
        }

        private void btnUnpackSheet_Click(object sender, EventArgs e)
        {
            if (sheet == null || sheet.IsDisposed)
            {
                sheet = new UnpackSheet();
            }
            sheet.Show();
        }
    }
}
