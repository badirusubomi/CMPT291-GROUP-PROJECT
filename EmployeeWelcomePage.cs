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
    public partial class EmployeeWelcomePage : Form
    {
        Form1 ths;
        public EmployeeWelcomePage(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            sidePanel.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            ths.loadBigForms(new AddMovie(ths));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            ths.loadBigForms(new AddEmployee(ths));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            ths.loadBigForms(new SalesReport(ths));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            ths.loadBigForms(new CollectCustomerInfo(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
