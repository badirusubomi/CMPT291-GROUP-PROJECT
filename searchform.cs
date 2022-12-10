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
    {   //SQL_Conn con_str = new SQL_Conn();
        Form1 ths;
        public searchform(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            //con_str = new SQL_Conn();
            //con_str.OpenConection();
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
                query += $"intersect (select * from Movies where Title like '%'+'{titleBox.Text}'+'%')";
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
                        $"as AI where M.MovieID = AI.MovieID AND T.ActorID = AI.ActorsID and T.ActorName " +
                        $"like '%'+ '{actorBox.Text}' + '%')";
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
            titleBox.ReadOnly = false;
            titleBox.Enabled = true;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            genreComboBox.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            actorBox.ReadOnly = false;
            actorBox.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            yearBox.ReadOnly = false;
            yearBox.Enabled = true;
        }

        private void title_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void genre_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void actor_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void year_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void genre_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            if (genreComboBox.Enabled)
            {
                genreComboBox.Enabled = false;
                genreComboBox.Text = "";
                
            }
            else
            {
                genreComboBox.Enabled = true;
            }
        }

        private void year_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            if (yearBox.Enabled)
            {
                yearBox.Enabled = false;
                yearBox.Text = "";
                yearBox.ReadOnly = true;
            }
            else
            {
                yearBox.Enabled = true;
                yearBox.ReadOnly = false;
            }
        }

        private void title_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            if (titleBox.Enabled)
            {
                titleBox.Enabled = false;
                titleBox.ReadOnly = true;
                titleBox.Text = "";
            }
            else
            {
                titleBox.Enabled = true;
                titleBox.ReadOnly= false;
            }
        }

        private void actor_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            if (actorBox.Enabled)
            {
                actorBox.Enabled = false;
                actorBox.ReadOnly = true;
                actorBox.Text = "";
            }
            else
            {
                actorBox.Enabled = true;
                actorBox.ReadOnly = false;
            }
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchform_Load(object sender, EventArgs e)
        {

        }
    }
}
