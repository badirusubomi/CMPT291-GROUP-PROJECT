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
    public partial class FAQpage : Form
    {
        Form1 ths;
        public FAQpage(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            this.button7.Hide();
            this.button8.Hide();
            this.button9.Hide();
            label3.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
