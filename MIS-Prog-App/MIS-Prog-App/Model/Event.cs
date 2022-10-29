using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MIS_Prog_App.Model
{
    public class Event
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime eventStartTime { get; set; }
        public DateTime eventEndTime { get; set; }

        public Event(string title, string loc, string start, string end)
        {
            Title = title;
            Location = loc;
            eventStartTime = DateTime.Parse(start);
            eventEndTime = DateTime.Parse(end);
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
