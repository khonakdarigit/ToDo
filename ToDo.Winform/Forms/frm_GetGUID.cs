using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Winform.Models;
using ToDo.Winform.Toos;

namespace ToDo.Winform.Forms
{
    public partial class frm_GetGUID : BaseForm
    {
        public frm_GetGUID()
        {
            InitializeComponent();
        }

        private void frm_GetGUID_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Guid guid = new Guid();

            if (Guid.TryParse(txt_GUID.Text, out guid))
            {
                using (var service_UserManagerClient = new ServiceReference_UserManager.Service_UserManagerClient())
                {
                    var taskyUser = service_UserManagerClient.GetUserWithGuid(ServiceUser.login, guid);
                    if (taskyUser != null)
                    {
                        Program.Create_appDataFile(taskyUser);
                        frm_Main frm_Main = new frm_Main();
                        frm_Main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("GUID not found !");
                    }
                }
            }
            else
            {
                throw new Exception("GUID Invalid , Pls Enter GUID");
            }

        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(Program.Get_Website());
            Process.Start(sInfo);
        }
    }
}
