using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMain.Services
{
    public class HolidayService
    {
        static DataContext dataContext = DataContext.getDatabaseInstance();
        static Random random = new Random();

        public enum HolidayReply
        {
            Next,
            Remaining
        }

        private static string[] Next_Replies =
        {
            "I would recommend you go on a holiday next month when the critical phases of your current project are completed",
            "Looks like now would be a good time to take some time off",
            "This week seems busy, maybe next week?"
        };

        private static string[] Remaining_Replies =
        {
            "You've got 5 days remaining",
            "You're allowed to take 8 days more days of leave",
            "I'm afraid you've exhausted all your holidays :("
        };

        public static string GetReply(HolidayReply reply)
        {
            string[] array = null;
            switch (reply)
            {
                case HolidayReply.Next:
                    array = Next_Replies;
                    break;
                case HolidayReply.Remaining:
                    array = Remaining_Replies;
                    break;
                default:
                    break;
            }
            return array[random.Next(0, array.Length)];
        }
    }
}