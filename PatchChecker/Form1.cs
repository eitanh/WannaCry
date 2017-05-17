
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
            PatchChecker.Service.Patches patches = new Service.Patches();
            List<HotfixInfo> list=patches.getPatches("192.168.59.131", username.Text, password.Text);
            table1.DataSource = list;
        }

        





    }
}
