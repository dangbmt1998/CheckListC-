namespace WindowsFormsTasksCheck
{
    partial class Form_Task
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
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTask = new System.Windows.Forms.ToolStripMenuItem();
            this.deletetask = new System.Windows.Forms.ToolStripMenuItem();
            this.editTask = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 28);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowTemplate.Height = 24;
            this.dgvTask.Size = new System.Drawing.Size(800, 422);
            this.dgvTask.TabIndex = 0;
            this.dgvTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTask,
            this.deletetask,
            this.editTask,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTask
            // 
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(80, 24);
            this.addTask.Text = "Add Task";
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // deletetask
            // 
            this.deletetask.Name = "deletetask";
            this.deletetask.Size = new System.Drawing.Size(96, 24);
            this.deletetask.Text = "Delete Task";
            // 
            // editTask
            // 
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(78, 24);
            this.editTask.Text = "Edit Task";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Form_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Task";
            this.Text = "Task Check";
            this.Load += new System.EventHandler(this.Form_Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTask;
        private System.Windows.Forms.ToolStripMenuItem deletetask;
        private System.Windows.Forms.ToolStripMenuItem editTask;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

