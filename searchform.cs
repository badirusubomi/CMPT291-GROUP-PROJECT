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
            string query = "";
            if (title.Checked)
            {
                query += $"intersect (select * from Movies where Title = '{titleBox.Text}')";
            }
            if (year.Checked)
            {
                query += $"intersect (select * from Movies where ReleaseYear = {yearBox.Text})";
            }
            if (genre.Checked)
            {
                query += $"intersect (select * from Movies where genre = '{genreComboBox.Text}')";
            }
            if (actor.Checked)
            {
                query += $"intersect (select M.Title from (select concat(A1.FName,' ' ,A1.LName) " +
                        $"as ActorName, A1.ActorID from Actors as A1) as T, Movies as M, Acts_In " +
                        $"as AI where M.MoviesID = AI.MovieID AND T.ActorID = AI.ActorID and T.ActorName " +
                        $"like {actorBox.Text})";
            }
            ths.AppUser._query = query.Remove(0,9);
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
                MessageBox.Show("Max 2 options:", "Please select 2 search option only");
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
