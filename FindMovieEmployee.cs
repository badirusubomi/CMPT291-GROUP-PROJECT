using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class FindMovieEmployee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        string customeridff;
        string movieIDths;
        SQL_Conn con_str;
        public FindMovieEmployee(Form1 frm, string customerIDf)
        {
            ths = frm;
            InitializeComponent();
            con_str = new SQL_Conn();
            con_str.OpenConection();
            nextButton.Hide();
            customeridff = customerIDf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new OrderConfirmationEmployee(ths, this.dateFrom.Text, this.dateTo.Text, customeridff, movieIDths));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (searchResult.Columns[e.ColumnIndex].Name == "CopyID")
                {
                    ths.AppUser._selectMovie = searchResult.CurrentCell.Value.ToString();
                    ths.AppUser._selectTitle = searchResult.CurrentRow.Cells["movieTitle"].Value.ToString();
                    movieIDths = searchResult.CurrentRow.Cells["movieID"].Value.ToString();
                    //MessageBox.Show($"Movie Title: {movieIDths}");
                    nextButton.Show();
                    nextButton.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Wrong cell selected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchResult.Rows.Clear(); // = null;
            string query = "";
            if (title.Checked)
            {
                query += $"intersect (select * from Movies where Title like '%{titleBox.Text.Trim()}%')";
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
                        $"like '%'+ '{actorBox.Text.Trim()}' + '%')";
            }
            ths.AppUser._query = query.Remove(0, 9);
            //======================================
            //string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                con_str.OpenConection();
                //myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //MessageBox.Show($"Query: {ths.AppUser._query}");
                //Start Queries
                myCommand.CommandText = $"select * from Copies as C7, ({ths.AppUser._query})" +
                                        $" as temp where C7.MovieID = temp.MovieID " +
                                        $"and C7.CopyID not in  (select C8.CopyID from Copies as C8, " +
                                        $"Orders as O2 where O2.CopyID = C8.CopyID and C8.CopyID = C7.CopyID and O2.MovieID = C7.MovieID " +
                                        $" and O2.MovieID = C8.MovieID and O2.Datefrom < '{dateFrom.Text}' and O2.DateTo > '{dateTo.Text}') ";
                                //Query needs revision
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        searchResult.Rows.Add(myReader["Title"].ToString(), myReader["CopyID"].ToString(),
                                              myReader["MovieID"].ToString(), myReader["Genre"].ToString(),
                                              myReader["ReleaseYear"].ToString(),
                                              myReader["Fee"].ToString(), myReader["MovieRating"]);
                        

                    }
                    
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
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
        private void button2_Click_1(object sender, EventArgs e)
        {

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
                titleBox.ReadOnly = false;
            }
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

        private void FindMovieEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new OrderConfirmationEmployee(ths, this.dateFrom.Text, this.dateTo.Text, customeridff, movieIDths));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void actorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
