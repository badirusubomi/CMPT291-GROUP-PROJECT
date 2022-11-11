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
    public partial class searchResultForm : Form
    {
        Form1 ths;
        public searchResultForm(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            SelectMovie.Click += new EventHandler(SelectMovie_Click);
        }

        private void searchResultForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectMovie_Click(object sender, EventArgs e)
        {
            ths.loadForms(new PresentCopies(ths));
        }
    }
}
