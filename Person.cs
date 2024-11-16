using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookEF
{
    [Table("Person", Schema = "dbo")]

    public class Person
    {
        public Person()
        {

        }

        [Key, Column(Order = 0)]
        public int PersonID { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string PersonTitle { get; set; }
        public string PersonPhone { get; set; }
        public string PersonMobil { get; set; }
        public string PersonAddress { get; set; }

    }
}
