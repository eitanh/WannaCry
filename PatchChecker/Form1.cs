using SRLib.Service.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatchChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(username.Text+ " "+password.Text);
            getPatches("192.168.59.131", username.Text, password.Text);
        }

        private void getPatches(String host, String user, String password)
        {
            //SRLib.Service.SoftwareService software = new SRLib.Service.SoftwareService();
            //List<SRLib.Model.InstalledAppObject> apps= software.GetInstalledApps("192.168.59.131", "administrator", "10ligisha!");
            //foreach (SRLib.Model.InstalledAppObject app in apps)
            // {
            //    Console.WriteLine(app.Name);
            //}

            //do your code here
            WmiAction wmi = new WmiAction(host, user, password);
            if (!wmi.Connect()) return;

            List<HotfixInfo> list = new List<HotfixInfo>();
            using (var searcher = wmi.CreateSearcher("select * from Win32_QuickFixEngineering"))
            using (var collection = searcher.Get())
                foreach (var item in collection)
                    using (item)
                    {
                        string source = (string)item["CSName"];
                        string hotFixId = (string)item["HotFixID"];
                        string description = (string)item["Description"];
                        string installedBy = (string)item["InstalledBy"];
                        string installDate = (string)item["InstalledOn"];
                        //if (installDate != null)
                        //    installDate = ManagementDateTimeConverter.ToDateTime(installDate).ToString("yyyy-MM-dd HH:mm:ss");
                        list.Add(new HotfixInfo
                        {
                            Source = source,
                            HotfixId = hotFixId,
                            Description = description,
                            InstalledBy = installedBy,
                            InstallDate = installDate
                        });
                    }
            table1.DataSource = list;
        }





    }
}
