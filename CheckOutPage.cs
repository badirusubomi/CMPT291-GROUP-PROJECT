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
    public partial class CheckOutPage : Form
    {
        Form1 ths;
        public CheckOutPage(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckOutPage_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            ths.loadForms(new OrderConfirmedPage());
        }
    }
}
