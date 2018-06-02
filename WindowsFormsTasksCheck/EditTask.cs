using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace WindowsFormsTasksCheck
{
    public partial class EditTask : Form
    {
        public EditTask(Task task )
        {
            InitializeComponent();
            this.task = task;
        }
        private Task task;
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var db = new QUANLYTASKEntities();
            Task newtask = db.Tasks.Find(task.id);
            try
            {
                newtask.Task_name = this.tbNameTaskedit.Text;

                newtask.Complete = this.cbCompleEdit.Checked;

                newtask.Deadline = this.dtpDeadlineedit.Value;
                db.Entry(newtask).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            if (task.Complete == true)
            {
                this.cbCompleEdit.Checked = true;
            }
            else if (task.Complete == false)
            {
                this.cbCompleEdit.Checked = false;
            };
            this.tbNameTaskedit.Text = task.Task_name;
            this.dtpDeadlineedit.Value = task.Deadline.Value;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
