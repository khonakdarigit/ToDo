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
        private bool EditMode { get; }
        private ServiceReference_TaskManager.Task CurrnetTask { get; set; }
        public frm_NewTask()
        {
            InitializeComponent();
        }

        public frm_NewTask(bool editMode = false, ServiceReference_TaskManager.Task currnetTask = null)
        {
            EditMode = editMode;
            CurrnetTask = currnetTask;
            InitializeComponent();
        }
        public frm_NewTask(bool editMode = false, ServiceReference_TaskManager.TaskVM currnetTask = null)
        {
            EditMode = editMode;

            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                CurrnetTask = service_TaskManagerClient.GetTask(ServiceUser.login, currnetTask.Id);
            }
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
                {
                    service_TaskManagerClient.AddNewTask(ServiceUser.login, new ServiceReference_TaskManager.Task()
                    {
                        IsComplete = false,
                        Title = txt_TaskTitle.Text,
                        UserId = Program.Get_appData().User.Id
                    });
                }
            }
            else
            {
                using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
                {
                    CurrnetTask.Title = txt_TaskTitle.Text;
                    service_TaskManagerClient.UpdateTask(ServiceUser.login, CurrnetTask);
                }
            }
            this.Close();

        }

        private void frm_NewTask_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                this.Text = "Edit Task";
                btn_Save.Text = "Save";

                txt_TaskTitle.Text = CurrnetTask.Title;
            }
        }
    }
}
