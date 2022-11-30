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
        private int checkCounter;

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            // Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;       
            else
                checkCounter--;

            // prevent checking
            if (checkCounter == 3)
            {
                MessageBox.Show("YOU ARE EVIL", "Bad");
                box.Checked = false;
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }
    }
}
