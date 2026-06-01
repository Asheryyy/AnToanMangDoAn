using PlayFair;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmRSA = new frmRSA();
            frmRSA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmPf = new frmPf();
            frmPf.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
