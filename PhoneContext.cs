using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PhoneBookEF
{
    public class PhoneContext: DbContext 
    {
        public PhoneContext() : base(@"Server=.\sqlexpress; Database=PhoneDB; Persist Security Info=True;User ID=sa;Password=15421 ")
        {

        }

        public DbSet<Person> Person { get; set; }

    }
}
