using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MIS_Prog_App.Model
{
    public class Registration
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAdd { get; set; }

        public Registration(string firstN, string lastN, string email)
        {
            this.firstName = firstN;
            this.lastName = lastN;
            this.emailAdd = email;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}" +
                $"\n{emailAdd}";
        }
    }
}