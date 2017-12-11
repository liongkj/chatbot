using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMain.Services
{
    public class TaskService
    {

        public enum TaskReply
        {
            Current,
            Finish,
            Next
        }

        public static string GetCurrentReply()
        {
            return "";
        }

        public static string GetFinishReply()
        {
            return "";
        }

        public static string GetNextReply()
        {
            return "";
        }
    }
}