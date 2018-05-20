using Bug_Tracker.Common;
using Bug_Tracker.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bug_Tracker.Views
{
    public partial class TesterDashboard : Form
    {
        public TesterDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;

            LoopPanel loop = new LoopPanel();
            BugDAO bug = new BugDAO();
            loop.loopPanel(bug.getAllBugs(), panel1, this, new UpdateBug(false));
        }

        private void bugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bug().Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void TesterDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
