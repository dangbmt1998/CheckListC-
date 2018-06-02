namespace WindowsFormsTasksCheck
{
    partial class EditTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.dtpDeadlineedit = new System.Windows.Forms.DateTimePicker();
            this.cbCompleEdit = new System.Windows.Forms.CheckBox();
            this.tbNameTaskedit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dead Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complete";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(119, 279);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 3;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(340, 279);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // dtpDeadlineedit
            // 
            this.dtpDeadlineedit.Location = new System.Drawing.Point(191, 172);
            this.dtpDeadlineedit.Name = "dtpDeadlineedit";
            this.dtpDeadlineedit.Size = new System.Drawing.Size(261, 22);
            this.dtpDeadlineedit.TabIndex = 5;
            // 
            // cbCompleEdit
            // 
            this.cbCompleEdit.AutoSize = true;
            this.cbCompleEdit.Location = new System.Drawing.Point(191, 109);
            this.cbCompleEdit.Name = "cbCompleEdit";
            this.cbCompleEdit.Size = new System.Drawing.Size(18, 17);
            this.cbCompleEdit.TabIndex = 6;
            this.cbCompleEdit.UseVisualStyleBackColor = true;
            // 
            // tbNameTaskedit
            // 
            this.tbNameTaskedit.Location = new System.Drawing.Point(189, 47);
            this.tbNameTaskedit.Name = "tbNameTaskedit";
            this.tbNameTaskedit.Size = new System.Drawing.Size(263, 22);
            this.tbNameTaskedit.TabIndex = 7;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 328);
            this.Controls.Add(this.tbNameTaskedit);
            this.Controls.Add(this.cbCompleEdit);
            this.Controls.Add(this.dtpDeadlineedit);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.Load += new System.EventHandler(this.EditTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DateTimePicker dtpDeadlineedit;
        private System.Windows.Forms.CheckBox cbCompleEdit;
        private System.Windows.Forms.TextBox tbNameTaskedit;
    }
}