using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatchChecker
{
    public class AppData
    {
        private static AppData instance;

        private AppData() { }

        public static AppData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppData();
                }
                return instance;
            }
        }

        public string Host { get; set; }
        public Credentials credentials { get; set; }
    }
}
