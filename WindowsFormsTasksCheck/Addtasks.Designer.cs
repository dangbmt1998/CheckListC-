namespace WindowsFormsTasksCheck
{
    partial class Addtasks
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
            this.SaveAdd = new System.Windows.Forms.Button();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameTask = new System.Windows.Forms.TextBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SaveAdd
            // 
            this.SaveAdd.Location = new System.Drawing.Point(95, 233);
            this.SaveAdd.Name = "SaveAdd";
            this.SaveAdd.Size = new System.Drawing.Size(117, 23);
            this.SaveAdd.TabIndex = 0;
            this.SaveAdd.Text = "Save";
            this.SaveAdd.UseVisualStyleBackColor = true;
            this.SaveAdd.Click += new System.EventHandler(this.SaveAdd_Click);
            // 
            // CancelAdd
            // 
            this.CancelAdd.Location = new System.Drawing.Point(328, 233);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(116, 23);
            this.CancelAdd.TabIndex = 1;
            this.CancelAdd.Text = "Cancel";
            this.CancelAdd.UseVisualStyleBackColor = true;
            this.CancelAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dead Line";
            // 
            // tbNameTask
            // 
            this.tbNameTask.Location = new System.Drawing.Point(201, 63);
            this.tbNameTask.Name = "tbNameTask";
            this.tbNameTask.Size = new System.Drawing.Size(243, 22);
            this.tbNameTask.TabIndex = 4;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(201, 139);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(243, 22);
            this.dtpDeadline.TabIndex = 5;
            // 
            // Addtasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.tbNameTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelAdd);
            this.Controls.Add(this.SaveAdd);
            this.Name = "Addtasks";
            this.Text = "Addtasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveAdd;
        private System.Windows.Forms.Button CancelAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameTask;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
    }
}