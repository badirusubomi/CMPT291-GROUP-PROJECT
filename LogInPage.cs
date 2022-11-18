using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class LogInPage : Form
    {
        Form1 ths;
        public LogInPage(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (employeeRadio.Checked)
            {
                   
                ths.loadBigForms(new employeeMainPage(ths));
            }
            //ths.showForms(ths);
            //ths.loadForms(new searchform(ths));
            ths.loadBigForms(new employeeMainPage(ths));
            //ths.loadBigForms(new LogInPage(ths));            
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void employeeRadio_CheckedChanged(object sender, EventArgs e)
        {
      
        }
    }
}
