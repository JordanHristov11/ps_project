using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static private StringBuilder currentSessionActivity= new StringBuilder();
        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserName + ";"
            + LoginValidation.currentUserRole + ";"
            + activity;
            currentSessionActivities.Add(activityLine);

            if (File.Exists("Logs.txt") == true)
            {
                foreach (string str in currentSessionActivities)
                {
                    currentSessionActivity.AppendLine(str);
                    File.AppendAllText("Logs.txt", str);
                }
            }
        }
        static public IEnumerable<string> ShowLogActivity()
        {
            StreamReader sr = new StreamReader("Logs.txt");
            List<string> list = new List<string>();
            list.Add(sr.ReadLine());
            return list;
        }
        static public IEnumerable<string> ShowCurrentActivity(string filter)
        {
            List<string> filteredActivities =
                (from line in /*File.ReadLines("Logs.txt")*/ currentSessionActivities
                 where line.Contains(filter) select line).ToList();
            return filteredActivities;
        }
    }
}
