﻿using Bug_Tracker.DAO;
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
    public partial class CauseSymptomsAndAssign : Form
    {
        int id = 0;
        private int programmerId = 0;


        public CauseSymptomsAndAssign()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SymptonsAndAssign_Load(object sender, EventArgs e)
        {

            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = bugInformationDAO.GetById(Program.bugId);

            if (bugInformation != null)
            {
                button1.Hide();
                button2.Show();
                textBox1.Text = bugInformation.Symtons;
                textBox2.Text = bugInformation.Cause;
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            ProgrammerDAO programmerDAO = new ProgrammerDAO();
            List<Programmer> list = programmerDAO.GetAll();


            foreach (var l in list)
            {
                comboBox1.Items.Add(l.ProgrammerId + "," + l.FullName);
            }

            assignedUser();
        }

        private void assignedUser()
        {
            listBox1.Items.Clear();
            AssignDAO assignDAO = new AssignDAO();
            List<string> assignList = assignDAO.GetAllAssignedUsersByBugId(Program.bugId);
            foreach (var a in assignList)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Update(bugInformation);
                    MessageBox.Show("Updated");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assignedUser();
            Assign assign = new Assign
            {
                AssignBy = Login.userId,
                AssignTo = id,
                Description = textBox3.Text,
                BugId = Program.bugId
            };

            AssignDAO assignDAO = new AssignDAO();

            try
            {
                assignDAO.Insert(assign);
                MessageBox.Show("Task assigned");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button4.Show();
            AssignDAO bugInformationDAO = new AssignDAO();
            string value = comboBox1.SelectedItem.ToString();
            string[] s = value.Split(',');

            id = Convert.ToInt32(s[0]);

            Assign assign = new Assign
            {
                AssignBy = Program.userId,
                AssignTo = id,
                Description = textBox3.Text.ToString()
            };

            try
            {
                bugInformationDAO.Insert(assign);
                MessageBox.Show("Task assigned");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void updateBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new UpdateBug().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Insert(bugInformation);
                    MessageBox.Show("Added");
                    button1.Hide();
                    button2.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
