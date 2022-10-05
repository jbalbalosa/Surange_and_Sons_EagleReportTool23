using System;
using System.Windows.Forms;

namespace EagleReportTool23
{

    public partial class frmMain : Form
    {
        //Declare Global Variable//
        public const string MessageBoxCaption = "ERT23";

        public frmMain()
        {
            InitializeComponent();
        }

        public void CloseApplication()
        {
            const string message = "Are you sure you want to close the application?";
            var response = MessageBox.Show(message, MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
