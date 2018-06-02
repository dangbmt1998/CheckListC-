using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTasksCheck
{
    public partial class Form_Task : Form
    {
        public Form_Task()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Task_Load);
        }
        private void ShowTaskList()
        {
            var db = new QUANLYTASKEntities();
            this.dgvTask.DataSource = db.Tasks.ToList();
        }
        private void Form_Task_Load(object sender, EventArgs e)
        {
            this.ShowTaskList();
        }

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            var form = new Addtasks();
            form.Show();
            this.ShowTaskList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowTaskList();
        }

        private void deletetask_Click(object sender, EventArgs e)
        {
            var db = new QUANLYTASKEntities();
            for (int i = 0; i < this.dgvTask.SelectedRows.Count; i++)
            {
                var row = this.dgvTask.SelectedRows[i];
                var item = (Task)row.DataBoundItem;
                try
                {
                    var task = db.Tasks.Find(item.id);
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.ShowTaskList();
        }

        private void editTask_Click(object sender, EventArgs e)
        {

        }

        private void dgvTask_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvTask.SelectedRows.Count == 1)
            {
                var row = this.dgvTask.SelectedRows[0];
                var item = (Task)row.DataBoundItem;
                var form = new EditTask(item);
                form.ShowDialog();
                this.ShowTaskList();
            }
        }
    }
}
