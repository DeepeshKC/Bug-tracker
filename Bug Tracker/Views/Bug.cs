using Bug_Tracker.Common;
using Bug_Tracker.DAO;
using Bug_Tracker.Model;
using System;
using System.Collections;
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
    public partial class Bug : Form
    {
        public Bug()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Bug_Load(object sender, EventArgs e)
        {
            panelBugs.AutoScroll = false;
            panelBugs.HorizontalScroll.Enabled = false;
            panelBugs.HorizontalScroll.Visible = false;
            panelBugs.HorizontalScroll.Maximum = 0;
            panelBugs.AutoScroll = true;

            panelAssigned.AutoScroll = false;
            panelAssigned.HorizontalScroll.Enabled = false;
            panelAssigned.HorizontalScroll.Visible = false;
            panelAssigned.HorizontalScroll.Maximum = 0;
            panelAssigned.AutoScroll = true;

            BugDAO bugDao = new BugDAO();

            try
            {
                List<Bug> list = bugDao.getAllBugs();
                var newLoopPanel = new LoopPanel();
                var newUpdateBug = new UpdateBug(false);
                newLoopPanel.loopPanel(list, panelBugs, this, newUpdateBug);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                List<Bug> bug = bugDao.GetAllBugsByProgrammerId(Login.userId);
                var newLoopPanel = new LoopPanel();
                var newUpdateBug = new UpdateBug(true);
                newLoopPanel.loopPanel(bug, panelAssigned, this, newUpdateBug);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
