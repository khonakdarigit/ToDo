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
    public partial class frm_NewTask : BaseForm
    {
        public frm_NewTask()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ServiceReference_TaskManager.Service_TaskManagerClient service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient();

            service_TaskManagerClient.AddNewTask(new ServiceReference_TaskManager.Task()
            {
                IsComplete = false,
                Title = txt_TaskTitle.Text,
                UserId=Program.appData.User.Id
            });

            this.Close();
        }
    }
}
