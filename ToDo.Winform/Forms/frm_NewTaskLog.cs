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
        public frm_NewTaskLog(ServiceReference_TaskLog.TaskLog cuurntTaskLog, bool editMode = false)
        {
            EditMode = editMode;
            CuurntTaskLog = cuurntTaskLog;
            InitializeComponent();
        }

        private bool EditMode { get; }
        private ServiceReference_TaskLog.TaskLog CuurntTaskLog { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
                {
                    service_TaskLogClient.AddNewTaskLog(new ServiceReference_TaskLog.TaskLog()
                    {
                        Title = txt_TaskLogTitle.Text,
                        Description = txt_taskLogDescription.Text,
                        TaskId = CuurntTaskLog.TaskId,

                    });
                    this.Close();
                }
            }
            else
            {
                using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
                {
                    CuurntTaskLog.Title = txt_TaskLogTitle.Text;
                    CuurntTaskLog.Description = txt_taskLogDescription.Text;

                    service_TaskLogClient.UpdateTaskLog(CuurntTaskLog); 
                    this.Close();
                }
            }
        }

        private void frm_NewTaskLog_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                this.Text = "Edit Task Log";
                btn_Save.Text = "Save";

                txt_TaskLogTitle.Text = CuurntTaskLog.Title;
                txt_taskLogDescription.Text = CuurntTaskLog.Description;
            }
        }
    }
}
