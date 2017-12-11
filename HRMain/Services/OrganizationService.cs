using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMain.Services
{
    public class OrganizationService
    {

        public enum OrganizationReply
        {
            DressCode,
            Location
        }

        private static string[] DressCode_Replies =
        {
            "The organization recommends wearing smart casual on Fridays and formal on the other weekdays",
            "It is suggested that employees of the organization wear smart casual on Fridays and formal on the other weekdays"
        };

        private static string[] Location_Replies =
        {
            "The toilet is located at 4th floor",
            "You can find the cafetaria on the ground floor",
            "You'll find it on level 3"
        };

        public static string GetDressCodeReply()
        {
            Random random = new Random();
            return DressCode_Replies[random.Next(0, DressCode_Replies.Length)];
        }

        public static string GetLocationReply(string location)
        {
            foreach (var item in Location_Replies)
            {
                if (item.Contains(location.ToLowerInvariant()))
                    return item;
            }
            return Location_Replies[2];
        }
    }
}