using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Winform.Toos;

namespace ToDo.Winform.Forms
{
    public partial class frm_NewTaskLog : BaseForm
    {
        public frm_NewTaskLog(ServiceReference_TaskLog.TaskLog cuurntTaskLog, FormMode formMode = FormMode.New)
        {
            FormMode = formMode;
            CuurntTaskLog = cuurntTaskLog;
            InitializeComponent();
        }
        public FormMode FormMode { get; }
        private ServiceReference_TaskLog.TaskLog CuurntTaskLog { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormMode.None:
                    break;
                case FormMode.New:
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
                    break;
                case FormMode.Update:
                    using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
                    {
                        CuurntTaskLog.Title = txt_TaskLogTitle.Text;
                        CuurntTaskLog.Description = txt_taskLogDescription.Text;

                        service_TaskLogClient.UpdateTaskLog(CuurntTaskLog);
                        this.Close();
                    }
                    break;
                case FormMode.View:
                    break;
                default:
                    break;
            }
        }

        private void frm_NewTaskLog_Load(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormMode.None:
                    break;
                case FormMode.New:
                    break;
                case FormMode.Update:

                    this.Text = "Edit Task Log";
                    btn_Save.Text = "Save";

                    txt_TaskLogTitle.Text = CuurntTaskLog.Title;
                    txt_taskLogDescription.Text = CuurntTaskLog.Description;

                    break;
                case FormMode.View:

                    this.Text = "View Task Log";

                    txt_TaskLogTitle.Text=CuurntTaskLog.Title;
                    txt_taskLogDescription.Text=CuurntTaskLog.Description;

                    txt_TaskLogTitle.ReadOnly = true;
                    txt_taskLogDescription.ReadOnly = true;

                    btn_Save.Visible = false;

                    break;
                default:
                    break;
            }
        }
    }
}
