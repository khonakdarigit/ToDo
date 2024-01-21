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
using ToDo.Winform.ServiceReference_UserManager;
using ToDo.Winform.Toos;

namespace ToDo.Winform
{
    internal static class Program
    {
        private static string AppData_fileName = "AppData.json";
        private static string WebSite = @"http://tasky.us.to/";
        private static AppData _appData;

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
                    _appData = new JsonPersister().Deserialize<AppData>(AppData_fileName);
                    Application.Run(new frm_Main());
                }
                else
                {
                    Application.Run(new frm_GetGUID());
                }


            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

        }



        private static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs t)
        {
            Exception ex = (Exception)t.Exception;
            ShowError(ex);
            LogError(ex);
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
                MessageBox.Show(
                    errorMsg,
                    "Please contact the adminstrator",
                    MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Stop
                    );
            }
        }


        private static void LogError(Exception ex)
        {
            using (var service_LogClient = new ServiceReference_Log.Service_LogClient())
            {
                service_LogClient.NewLog(ServiceUser.login, new ServiceReference_Log.Log()
                {
                    LogTitle = ex.Message,
                    LogDetail = ex.StackTrace,
                    LogLevel = LogLevel.Error.ToString(),
                });
            }
        }

        #region Methods
        internal static void ChangeAppData_Option_ShowCompleteTask(bool @checked)
        {
            _appData.appOptions.Option_ShowCompleteTask = @checked;
            new JsonPersister().Serialize<AppData>(AppData_fileName, _appData);
        }
        internal static AppData Create_appDataFile(User taskyUser)
        {
            var appData = new AppData() { User = taskyUser, appOptions = new AppOptions() { Option_ShowCompleteTask = true } };
            new JsonPersister().Serialize<AppData>(AppData_fileName, appData);
            _appData = appData;
            return appData;
        }
        internal static AppData Get_appData()
        {
            return _appData;
        }

        internal static string Get_Website()
        {
            return WebSite;
        }
        #endregion
    }
}
