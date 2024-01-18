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
    public partial class frm_Main : BaseForm
    {
        public static ServiceReference_TaskManager.Task CurrntTask { get; set; }
        public static ServiceReference_TaskLog.TaskLog CurrntTaskLog { get; set; }

        public frm_Main()
        {
            InitializeComponent();
        }

        #region Events
        private void frm_Main_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_ID.Text = $"Your ID : {Program.appData.User.GUID}";

            FillTasks();

        }

        private void btn_NewTask_Click(object sender, EventArgs e)
        {
            frm_NewTask frm_GetTask = new frm_NewTask();
            frm_GetTask.ShowDialog();

            FillTasks();
        }

        private void taskBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrntTask = taskBindingSource.Current as ServiceReference_TaskManager.Task;
            FillTaskLog();
        }
        private void taskLogBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrntTaskLog = taskLogBindingSource.Current as ServiceReference_TaskLog.TaskLog;
        }

        private void btn_AddNewTaskLog_Click(object sender, EventArgs e)
        {
            frm_NewTaskLog frm_NewTaskLog = new frm_NewTaskLog();
            frm_NewTaskLog.ShowDialog();
            FillTaskLog();
        }

        #endregion


        #region Methods
        private void FillTasks()
        {
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var Tasks = service_TaskManagerClient.GetAllTasks(Program.appData.User.GUID);
                taskBindingSource.CurrentChanged -= taskBindingSource_CurrentChanged;
                taskBindingSource.DataSource = Tasks;
                taskBindingSource.CurrentChanged += taskBindingSource_CurrentChanged;


            }
        }

        private void FillTaskLog()
        {
            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var TaskLog = service_TaskLogClient.GetAllTaskLog(CurrntTask.Id);
                taskLogBindingSource.DataSource = TaskLog;
            }
        }

        #endregion


    }
}
