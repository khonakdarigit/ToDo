using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDo.WCF.EF.ViewMdels;

namespace ToDo.WCF.EF
{
    public static class ModelTranslator
    {
        public static TaskVM TaskToTaskVM(Task task)
        {
            var vm = new TaskVM();
            vm.Id = task.Id;
            vm.UserId = task.UserId;
            vm.CreationDate = task.CreationDate;
            vm.DoneDate = task.DoneDate;
            vm.IsComplete = task.IsComplete;
            vm.TaskLogCount = task.TaskLogs.Count;
            vm.Title = task.Title;

            vm.TaskLogs = new List<TaskLogVM>();
            vm.TaskLogs = TaskLogsToTaskLogsVM(task.TaskLogs);

            return vm;
        }

        public static TaskLogVM TaskLogToTaskLogVM(TaskLog taskLog)
        {
            var vm = new TaskLogVM()
            {
                Id = taskLog.Id,
                CreationDate = taskLog.CreationDate,
                Description = taskLog.Description,
                TaskId = taskLog.TaskId,
                Title = taskLog.Title,
            };
            return vm;
        }

        public static List<TaskVM> TasksToTasksVM(ICollection<Task> tasks)
        {
            var vm = tasks.Select(c => new TaskVM()
            {
                CreationDate = c.CreationDate,
                DoneDate = c.DoneDate,
                Id = c.Id,
                Title = c.Title,
                IsComplete = c.IsComplete,
                TaskLogCount = c.TaskLogs.Count,
                UserId = c.UserId,
                TaskLogs = TaskLogsToTaskLogsVM(c.TaskLogs)
            }).ToList();

            return vm;
        }

        private static List<TaskLogVM> TaskLogsToTaskLogsVM(ICollection<TaskLog> taskLogs)
        {
            var vm = taskLogs.Select(c => new TaskLogVM()
            {
                Id = c.Id,
                CreationDate = c.CreationDate,
                Description = c.Description,
                TaskId = c.TaskId,
                Title = c.Title,
            }).ToList();

            return vm;
        }
    }
}