using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatchChecker
{
    class HotfixInfo
    {
        public string Source { get; set; }
        public string HotfixId { get; set; }
        public string Description { get; set; }
        public string InstallDate { get; set; }
        public string InstalledBy { get; set; }
    }
}
