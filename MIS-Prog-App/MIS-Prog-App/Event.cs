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
        public string Location {get; set;}
        public DateTime eventStartTime { get; set; }
        public DateTime eventEndTime { get; set; }
        
        public Event(string title, string loc, string start, string end)
        {
            this.Title=title;
            this.Location = loc;
            this.eventStartTime = DateTime.Parse(start);
            this.eventEndTime = DateTime.Parse(end);
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"{Title}" + 
                $"\n{Location} from {eventStartTime} to {eventEndTime}";
            Console.ResetColor();
        }
    }
}
