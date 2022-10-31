using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_Prog_AppTest.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAdd { get; set; }

        public Registration()
        {
        }

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
