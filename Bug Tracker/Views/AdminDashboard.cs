using Bug_Tracker.DAO;
using Bug_Tracker.Model;
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
        public partial class AdminDashboard : Form
    {
        private int projectId = 0;
        private int programmerId = 0;

        public AdminDashboard()
        {
            InitializeComponent();
            GetAllProgrammers();
            btnAdd.Visible = false;
        }

        private void GetAllProgrammer()
        {
            ProgrammerDAO programmerDAO = new ProgrammerDAO();
            //Programmer p = programmerDAO.GetById(programmerId);
            List<String> programmers = new List<String>();

            ProjectProgrammerDAO projectProgrammerDAO = new ProjectProgrammerDAO();
            List<ProjectProgrammer> list = projectProgrammerDAO.GetAllProjectsByProjectId(projectId);
            //projectProgrammerDAO.GetAll();

            foreach (var l in list)
            {
                Programmer p = programmerDAO.GetById(Convert.ToInt32(l.ProgrammerId));
                programmers.Add(p.ProgrammerId + "," + p.FullName);
            }

            foreach (var a in programmers)
            {
                listBox1.Items.Add(a);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            Project project = new Project { ProjectName = projectName };

            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("You must add some project");
            }
            else
            {
                ProjectDAO projectDAO = new ProjectDAO();
                projectDAO.Insert(project);
                listView1.Items.Clear();
                GetAllProject();
            }
        }
        ////Return all the project
        private void GetAllProject()
        {
            ProjectDAO projectDAO = new ProjectDAO();
            List<Project> project = projectDAO.GetAll();

            foreach (var p in project)
            {
                listView1.Items.Add(p.ProjectId + "," + p.ProjectName);
            }
        }
   
        /// returns all the programmers
        private void GetAllProgrammers()
        {
            ProgrammerDAO dao = new ProgrammerDAO();
            List<Programmer> list = dao.GetAll();

            foreach (var l in list)
            {
                comboBox1.Items.Add(l.ProgrammerId + "," + l.FullName);
            }
        }
        

        private void addUserToComapnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Register_Account().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            this.Hide();
            Program.adminId = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                ProjectDAO projectDAO = new ProjectDAO();
                bool res = projectDAO.Delete(projectId);

                if (res)
                {
                    listView1.Items.Clear();
                    GetAllProject();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //maile close button haru haleko xaina milau hai tini haru chahi kaa ?
        //maile pheri login garnu paryo vane program purai katera kholnu parxa k tyo maile ni milako xaina 
        //timi mialaune vaye milau vanya k
        //ok pa bug ko
        private void button4_Click(object sender, EventArgs e)
        {
            string projectName = textBoxUpdate.Text;
            ProjectDAO projectDAO = new ProjectDAO();
            Project project = new Project
            {
                ProjectId = projectId,
                ProjectName = projectName
            };

            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("Project name is empty");
            }
            else
            {
                listView1.Items.Clear();
                projectDAO.Update(project);
                GetAllProject();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (projectId == 0)
            {
                MessageBox.Show("Plase select project name first");
            }
            else
            {
                ProjectProgrammerDAO projectProgrammerDAO = new ProjectProgrammerDAO();
                ProjectProgrammer projectProgrammer = new ProjectProgrammer
                {
                    ProjectId = projectId,
                    ProgrammerId = programmerId
                };

                try
                {
                    projectProgrammerDAO.Insert(projectProgrammer);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                listBox1.Items.Clear();
                GetAllProgrammer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Register_Account().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectProgrammerDAO projectProgrammer = new ProjectProgrammerDAO();
            bool res = projectProgrammer.Delete(programmerId);
            listBox1.Items.Clear();
            GetAllProgrammer();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Visible = true;

            string[] arr = comboBox1.Text.ToString().Split(',');
            programmerId = Convert.ToInt32(arr[0]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addUserToComapnyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            textBoxUpdate.Hide();
            GetAllProject();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            button3.Show();
            button4.Show();
            textBoxUpdate.Show();
            string[] arr = listView1.SelectedItems[0].ToString().Split(',');
            projectId = Convert.ToInt32(arr[0]);

            listBox1.Items.Clear();
            GetAllProgrammer();
        }
    }
}
