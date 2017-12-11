using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMain.Services
{
    public class ProjectService
    {
        static DataContext dataContext = DataContext.getDatabaseInstance();

        public enum ProjectReply
        {
            Description,
            Duration,
            JobScope,
            PersonInCharge,
            Phase
        }

        public static string GetDescriptionReply(string projectName)
        {
            return "It worked!";
        }

        public static string GetDurationReply()
        {
            return "";
        }

        public static string GetJobScopeReply()
        {
            return "";
        }

        public static string GetPersonInChargeReply()
        {
            return "";
        }

        public static string GetPhaseReply()
        {
            return "";
        }

        //public static string GetReply(ProjectReply reply)
        //{
        //    string[] array = null;
        //    switch (reply)
        //    {
        //        case RootReply.None:
        //            array = None_Replies;
        //            break;
        //        case RootReply.Greeting:
        //            array = Greeting_Replies;
        //            break;
        //        case RootReply.Others:
        //            array = Others_Replies;
        //            break;
        //        default:
        //            break;
        //    }
        //    Random random = new Random();
        //    return array[random.Next(0, array.Length)];
        //}

    }
}