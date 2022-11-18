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
    public partial class EmployeeFunctionsPage : Form
    {
        Form1 ths;
        public EmployeeFunctionsPage(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new Form1());
        }
    }
}
