using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatchChecker
{
    public partial class settings : Form
    {

        public Credentials credentials=new Credentials("","");
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            
            if (AppData.Instance.credentials != null)
            {
                
                username.Text = AppData.Instance.credentials.user;
                password.Text = AppData.Instance.credentials.password;
                host.Text = AppData.Instance.Host;
            }

        }
        public Credentials GetCredentials()
        {
            return this.credentials;
        }

        public String getHost()
        {
            return host.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.credentials.user = username.Text;
            this.credentials.password = password.Text;

            AppData.Instance.credentials = this.credentials;
            AppData.Instance.Host = host.Text;
        }

    }
}
