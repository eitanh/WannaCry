
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
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(username.Text+ " "+password.Text);
            PatchChecker.Service.Patches patches = new Service.Patches();
            settings settings = new settings();
            Credentials credentials = settings.GetCredentials();
            List<HotfixInfo> list=patches.getPatches(AppData.Instance.Host,AppData.Instance.credentials.user,AppData.Instance.credentials.password);
            //table1.DataSource = list;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }
    }
}
