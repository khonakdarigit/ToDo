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
    public partial class frm_NewTaskLog : BaseForm
    {
        public frm_NewTaskLog()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                service_TaskLogClient.AddNewTaskLog(new ServiceReference_TaskLog.TaskLog()
                {
                    Title = txt_TaskLogTitle.Text,
                    Description = txt_taskLogDescription.Text,
                    TaskId = frm_Main.CurrntTask.Id,

                });
                this.Close();
            }
        }
    }
}
