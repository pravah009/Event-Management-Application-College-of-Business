﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MIS_Prog_App.Models
{
    public partial class Event
    {
        public Event()
        {
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string EventTitle { get; set; }
        public string EventLocation { get; set; }
        public string EventStart { get; set; }
        public string EventEnd { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }

        public Event(string eventTitle, string eventLocation, string eventStart, string eventEnd)
        {
          
            EventTitle = eventTitle;
            EventLocation = eventLocation;
            EventStart = eventStart;
            EventEnd = eventEnd;
           
        }
        public override string ToString()
        {

            return $"{EventTitle} " +
                $"\n{EventLocation} from {EventStart} to {EventEnd}\n";

        }
    }
    
}