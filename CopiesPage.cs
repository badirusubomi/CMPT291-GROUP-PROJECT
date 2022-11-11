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
    public partial class PresentCopies : Form
    {
        Form1 ths;
        public PresentCopies(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            //RentButton.Hide();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            ths.loadForms(new CheckOutPage(ths));
        }
    }
}
