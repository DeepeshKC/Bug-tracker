namespace Bug_Tracker.Views
{
    partial class Bug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBugs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAssigned = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBugs.SuspendLayout();
            this.panelAssigned.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBugs
            // 
            this.panelBugs.BackColor = System.Drawing.Color.IndianRed;
            this.panelBugs.Controls.Add(this.label1);
            this.panelBugs.ForeColor = System.Drawing.SystemColors.Window;
            this.panelBugs.Location = new System.Drawing.Point(12, 68);
            this.panelBugs.Name = "panelBugs";
            this.panelBugs.Size = new System.Drawing.Size(555, 488);
            this.panelBugs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "All bugs";
            // 
            // panelAssigned
            // 
            this.panelAssigned.BackColor = System.Drawing.Color.Goldenrod;
            this.panelAssigned.Controls.Add(this.label2);
            this.panelAssigned.ForeColor = System.Drawing.SystemColors.Window;
            this.panelAssigned.Location = new System.Drawing.Point(573, 68);
            this.panelAssigned.Name = "panelAssigned";
            this.panelAssigned.Size = new System.Drawing.Size(509, 488);
            this.panelAssigned.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Assigned Work";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBugToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // updateBugToolStripMenuItem
            // 
            this.updateBugToolStripMenuItem.Name = "updateBugToolStripMenuItem";
            this.updateBugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateBugToolStripMenuItem.Text = "Update Bug";
            this.updateBugToolStripMenuItem.Click += new System.EventHandler(this.updateBugToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 39);
            this.label3.TabIndex = 24;
            this.label3.Text = "List of the bugs:";
            // 
            // Bug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBugs);
            this.Controls.Add(this.panelAssigned);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Bug";
            this.Text = "Bug";
            this.Load += new System.EventHandler(this.Bug_Load);
            this.panelBugs.ResumeLayout(false);
            this.panelBugs.PerformLayout();
            this.panelAssigned.ResumeLayout(false);
            this.panelAssigned.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAssigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}