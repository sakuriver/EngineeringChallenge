using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicInformationPMQ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkManager work = new WorkManager();
            work.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetWorkManager netWorkManager = new NetWorkManager();
            netWorkManager.Show();
        }
    }
}
