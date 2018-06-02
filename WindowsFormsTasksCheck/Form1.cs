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
    }
}
