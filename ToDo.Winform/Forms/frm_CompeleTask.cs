using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.Winform.Forms
{
    public partial class frm_CompeleTask : BaseForm
    {
        public frm_CompeleTask(ServiceReference_TaskManager.Task currntTask)
        {
            CurrntTask = currntTask;
            InitializeComponent();
        }

        public ServiceReference_TaskManager.Task CurrntTask { get; set; }

        private void frm_CompeleTask_Load(object sender, EventArgs e)
        {
            txt_TaskTitle.Text = CurrntTask.Title;
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            using(var service_TaskManagerClient =new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                CurrntTask.IsComplete = true;
                service_TaskManagerClient.UpdateTask(ServiceUser.login, CurrntTask);
                this.Close();
            }
        }

        private void btn_NotComplete_Click(object sender, EventArgs e)
        {
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                CurrntTask.IsComplete = false;
                service_TaskManagerClient.UpdateTask(ServiceUser.login, CurrntTask);
                this.Close();
            }
        }
    }
}
