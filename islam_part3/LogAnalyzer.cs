using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class LogAnalyzer
    {
        public static void Start()
        {
            int foundDay;
            int lengthDay=0;
            int foundTime;
            int foundError;
            
           
            string[] logs = new string[] { 
                "2023-11-12 08:30:00 INFO Applicatioвn started successfully",
                "2023-11-12 08:45:23 WARNING Low memory warning detected",
                "2023-11-12 09:15:45 ERROR Failed to connect to database", 
                "2023-11-12 10:30:33 WARNING Disk space is almost full",
                "2023-11-12 12:30:45 WARNING High CPU usage detected", 
                "2023-11-12 12:00:00 ERROR Email service is not responding",
                "2023-11-12 11:30:00 INFO Scheduled maintenance started", 
                "2023-11-12 11:00:05 INFO New user 'john_doe' created",
                "2023-11-12 11:20:05 INFO user 'john_doe' was deleted",
                "2023-11-12 10:00:00 ERROR Unexpected exception occurred" };
            foreach (string log in logs)
            {
                foundDay = log.IndexOf(" ");
                foundTime = log.IndexOf(" ", foundDay+1);
                foundError = log.IndexOf(" ", foundTime+1);
                int dateLength = foundDay - lengthDay;
                int timeLength = foundTime - foundDay - 1;
                int errorLevelLength = foundError - foundTime - 1;

                Console.WriteLine("Дата: {0}", log.Substring(lengthDay, dateLength));
                Console.WriteLine("Время: {0}", log.Substring(foundDay + 1, timeLength));
                Console.WriteLine("Уровень ошибки: {0}", log.Substring(foundTime + 1, errorLevelLength));
                Console.WriteLine("Сообщение: {0}", log.Substring(foundError + 1));
                Console.WriteLine();
            }




        }
        
    }
}
