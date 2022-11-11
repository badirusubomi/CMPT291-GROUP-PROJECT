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
    public partial class searchform : Form
    {
        Form1 ths;
        public searchform(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            button1.Click += new EventHandler(button1_Click);
        }
        public Form1 Form { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadForms(new searchResultForm(ths));
        }
    }
}
