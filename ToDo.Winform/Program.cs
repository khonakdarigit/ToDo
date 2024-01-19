using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasky.Models.Tools;
using ToDo.Winform.Forms;
using ToDo.Winform.Models;
using ToDo.Winform.Toos;

namespace ToDo.Winform
{
    internal static class Program 
    {
        private static string AppData_fileName = "AppData.json";
        private static string LogData_fileName = "LogData.json";

        private static string WebSite = @"http://tasky.us.to/";
        private static AppData appData;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(MyCommonExceptionHandlingMethod);

            try
            {
                if (File.Exists(AppData_fileName))
                {
                    appData = new JsonPersister().Deserialize<AppData>(AppData_fileName);
                }
                else
                {
                    ServiceReference_UserManager.Service_UserManagerClient service_UserManagerClient = new ServiceReference_UserManager.Service_UserManagerClient();
                    var User = service_UserManagerClient.GetNewUSer();

                    appData = new AppData() { User = User, appOptions = new AppOptions() { Option_ShowCompleteTask = true } };
                    new JsonPersister().Serialize<AppData>(AppData_fileName, appData);
                }


            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

            Application.Run(new frm_Main());

        }



        private static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs t)
        {
            Exception ex = (Exception)t.Exception;
            ShowError(ex);

        }

        private static void ShowError(Exception ex)
        {
            if (ex.Message.Contains("Access to the path"))
            {
                MessageBox.Show("Plase [Run as administrator] for the program to work properly ", "Run as administrator is required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string errorMsg = "An application error occurred. Please contact the adminstrator " +
               "with the following information:\n\n" + Program.WebSite;
                MessageBox.Show(errorMsg, "Please contact the adminstrator", MessageBoxButtons.AbortRetryIgnore,
                 MessageBoxIcon.Stop);

                LogError(ex);
            }
        }


        private static void LogError(Exception ex)
        {
            ServiceReference_Log.Service_LogClient service_LogClient = new ServiceReference_Log.Service_LogClient();
            service_LogClient.NewLog(new ServiceReference_Log.Log()
            {
                LogTitle = ex.Message,
                LogDetail = ex.StackTrace,
                LogLevel = LogLevel.Error.ToString(),
            });
        }

        #region Methods
        internal static void ChangeAppData_Option_ShowCompleteTask(bool @checked)
        {
            appData.appOptions.Option_ShowCompleteTask = @checked;
            new JsonPersister().Serialize<AppData>(AppData_fileName, appData);
        }

        internal static AppData Get_appData()
        {
            return appData;
        }
        #endregion
    }
}
