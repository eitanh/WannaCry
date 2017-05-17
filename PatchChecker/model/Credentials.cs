using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatchChecker
{
    public class Credentials
    {
        public String user { get; set; }
        public String password { get; set; }

        public Credentials(String user,String password)
        {
            this.user = user;
            this.password = password;
        }
    }
}
