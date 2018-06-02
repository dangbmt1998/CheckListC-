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
    public partial class Addtasks : Form
    {
        public Addtasks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAdd_Click(object sender, EventArgs e)
        {
            var db = new QUANLYTASKEntities();
            DateTime localDate = DateTime.Now;
            Task task = new Task();
            task.Task_name = this.tbNameTask.Text;
            task.Time_create = localDate;
            task.Deadline = this.dtpDeadline.Value;
            task.Complete = false;
            try
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
