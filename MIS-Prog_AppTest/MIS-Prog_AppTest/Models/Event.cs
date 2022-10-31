using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_Prog_AppTest.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Auto increment
        public int ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime eventStartTime { get; set; }
        public DateTime eventEndTime { get; set; }

        public Event()
        {
        }

        public Event(string title, string loc, string start, string end)
        {
            Title = title;
            Location = loc;
            eventStartTime = DateTime.Parse(start);
            eventEndTime = DateTime.Parse(end);
        }

        public override string ToString()
        {
            return $"{Title}" +
                $"\n{Location} from {eventStartTime} to {eventEndTime}";
        }
    }
}
