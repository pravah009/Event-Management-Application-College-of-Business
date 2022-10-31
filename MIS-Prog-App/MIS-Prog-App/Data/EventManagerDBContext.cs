using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIS_Prog_App.Model;

namespace MIS_Prog_App.Data
{
    public class EventManagerDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> RSVP { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=Data/eventManager.db");
        }
    }
}