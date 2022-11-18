using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class AboutPage : Form
    {
        Form1 ths;
        public AboutPage(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ths.showForms(ths);
            ths.loadForms(new searchform(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
