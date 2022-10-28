using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MIS_Prog_App
{
    public class Event
    {
        public string Title { get; set; }
        public string eventType { get; set; }
        public string eventDept { get; set; }
        public string Location {get; set;}
        public string Company{get; set;}
        public DateTime eventDate { get; set; }
        public string recruitorName {get; set;}
        
        public Event(string title, string type, string loc, string date)
        {
            this.Title=title;
            this.eventType = type;
            this.eventDept=string.Empty;
            this.Location = loc;
            this.eventDate = DateTime.Parse(date);
            this.Company = string.Empty;
            this.recruitorName = string.Empty;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"{Title}" +
                $"\n{eventType} by {eventDept}" +
                $"\n{Location} at {eventDate}";
            Console.ResetColor();
        }
    }
}
