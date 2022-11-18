﻿using System;
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
    public partial class employeeMainPage : Form
    {
        Form1 ths;
        public employeeMainPage(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeFunctionsPage(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ths.showForms(ths);
        }
    }
}
