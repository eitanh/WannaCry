using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatchChecker.Service
{
    class Patches
    {
        public void getPatches()
        {
            SRLib.Service.SoftwareService software = new SRLib.Service.SoftwareService();
            List<SRLib.Model.InstalledAppObject> apps = software.GetInstalledApps("192.168.59.131", "administrator", "10ligisha!");
            foreach (SRLib.Model.InstalledAppObject app in apps)
            {
                Console.WriteLine(app.Name);
            }
        }
    }
}
