using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMain.Services
{
    public class RootService
    {
        public enum RootReply
        {
            None,
            Greeting,
            Others
        }

        private static string[] None_Replies =
        {
            "Sorry, I didn't get that. What were you trying to ask me?",
            "I didn't quite get that. How can I be of service?",
            "I don't know what you mean by that. How can I help you?"
        };

        private static string[] Greeting_Replies =
        {
            "Good day!",
            "Hi there! How can I help you today?",
            "Hello there",
            "Hey there",
            "Hello",
            "Hi"
        };

        private static string[] Others_Replies =
        {
            "Anything else I can help you with?",
            "Can I assist you with anything else?",
            "Is there anything else I can assist you with?",
            "Anything else?",
            "Anything else, boss?",
        };

        public static string GetReply(RootReply reply)
        {
            string[] array = null;
            switch(reply)
            {
                case RootReply.None:
                    array = None_Replies;
                    break;
                case RootReply.Greeting:
                    array = Greeting_Replies;
                    break;
                case RootReply.Others:
                    array = Others_Replies;
                    break;
                default:
                    break;
            }
            Random random = new Random();
            return array[random.Next(0, array.Length)];
        }

    }
}