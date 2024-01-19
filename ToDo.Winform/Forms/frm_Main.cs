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
    public partial class frm_Main : BaseForm
    {
        private static ServiceReference_TaskManager.Task CurrntTask { get; set; }
        private static ServiceReference_TaskLog.TaskLog CurrntTaskLog { get; set; }

        public frm_Main()
        {
            InitializeComponent();
        }

        #region Events
        private void frm_Main_Load(object sender, EventArgs e)
        {
            showCompletedTaskToolStripMenuItem.Checked = Program.Get_appData().appOptions.Option_ShowCompleteTask;
            toolStripStatusLabel_ID.Text = $"Your ID : {Program.Get_appData().User.GUID}";

            FillTasks();
            FillTaskLog();
        }

        #region Task Manager
        private void taskBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrntTask = taskBindingSource.Current as ServiceReference_TaskManager.Task;
            FillTaskLog();
        }

        private void btn_NewTask_Click(object sender, EventArgs e)
        {
            frm_NewTask frm_GetTask = new frm_NewTask();
            frm_GetTask.ShowDialog();

            FillTasks();
        }
        private void btn_EditTask_Click(object sender, EventArgs e)
        {
            frm_NewTask frm = new frm_NewTask(true, CurrntTask);
            frm.ShowDialog();

            FillTasks();
        }
        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            if (CurrntTask != null)
            {
                int TaskLogCount = 0;
                using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
                {
                    TaskLogCount = service_TaskLogClient.GetAllTaskLog(CurrntTask.Id).Count();
                }

                using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
                {
                    if (MessageBox.Show(
                            $"Are you sure you want to delete this task?\nTitle: {CurrntTask.Title}\nTaskLog Count: {TaskLogCount}",
                            "Delete Task ?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        service_TaskManagerClient.DeleteTask(CurrntTask);
                        FillTasks();
                        FillTaskLog();
                    }
                }
            }
        }

        private void btn_NewTask_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("New Task", btn_NewTask);
        }
        private void btn_EditTask_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("Edit Task", btn_EditTask);
        }
        private void btn_DeleteTask_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("Delete Task", btn_DeleteTask);
        }

        private void dg_tasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurrntTask != null)
            {
                frm_CompeleTask frm_CompeleTask = new frm_CompeleTask(CurrntTask);
                frm_CompeleTask.ShowDialog();
                FillTasks();
                FillTaskLog();
            }
        }

        #endregion

        #region Task Log Manager
        private void taskLogBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrntTaskLog = taskLogBindingSource.Current as ServiceReference_TaskLog.TaskLog;
        }
        private void btn_AddNewTaskLog_Click(object sender, EventArgs e)
        {
            frm_NewTaskLog frm_NewTaskLog = new frm_NewTaskLog(CurrntTaskLog);
            frm_NewTaskLog.ShowDialog();
            FillTaskLog();
        }

        private void btn_EditTaskLog_Click(object sender, EventArgs e)
        {
            frm_NewTaskLog frm_NewTaskLog = new frm_NewTaskLog(CurrntTaskLog, FormMode.Update);
            frm_NewTaskLog.ShowDialog();
            FillTaskLog();
        }

        private void btn_DeletTaskLog_Click(object sender, EventArgs e)
        {
            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var description = CurrntTaskLog.Description.Length < 50 ?
                    CurrntTaskLog.Description :
                    $"{CurrntTaskLog.Description.Take(50).ToString()}...";

                if (MessageBox.Show(
                           $"Are you sure you want to delete this task log?\n\nTitle: {CurrntTaskLog.Title}\nDescription: {description}",
                           "Delete Task Log?",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                       ) == DialogResult.Yes)
                {
                    service_TaskLogClient.DeleteTaskLog(CurrntTaskLog.Id);
                    FillTaskLog();
                }

            }
        }
        private void dt_TaskLog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurrntTaskLog != null)
            {
                frm_NewTaskLog frm_NewTaskLog = new frm_NewTaskLog(CurrntTaskLog, FormMode.View);
                frm_NewTaskLog.ShowDialog();
            }
        }

        private void btn_AddNewTaskLog_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("New Task Log", btn_AddNewTaskLog);
        }
        private void btn_EditTaskLog_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("Edit Task Log", btn_EditTaskLog);
        }
        private void btn_DeleteTaskLog_MouseHover(object sender, EventArgs e)
        {
            toolTipTasky.Show("Delete Task Log", btn_EditTaskLog);
        }

        #endregion

        #region Menu

        private void showCompletedTaskToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Program.ChangeAppData_Option_ShowCompleteTask(showCompletedTaskToolStripMenuItem.Checked);
            FillTasks();
            FillTaskLog();
        }
        #endregion

        #endregion


        #region Methods
        private void FillTasks()
        {
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var Tasks = service_TaskManagerClient.GetAllTasks(Program.Get_appData().User.GUID);
                taskBindingSource.CurrentChanged -= taskBindingSource_CurrentChanged;
                if (!Program.Get_appData().appOptions.Option_ShowCompleteTask)
                    Tasks = Tasks.Where(c => c.IsComplete == false).ToList();
                taskBindingSource.DataSource = Tasks;
                taskBindingSource.CurrentChanged += taskBindingSource_CurrentChanged;
                CurrntTask = taskBindingSource.Current as ServiceReference_TaskManager.Task;
            }
        }

        private void FillTaskLog()
        {
            if (CurrntTask != null)
            {
                using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
                {
                    var TaskLog = service_TaskLogClient.GetAllTaskLog(CurrntTask.Id);
                    taskLogBindingSource.DataSource = TaskLog;
                }
            }
            else
            {
                taskLogBindingSource.DataSource = null;
            }
        }





        #endregion


    }
}
