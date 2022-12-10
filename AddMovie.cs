using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class AddMovie : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        //SQL_Conn con_str;
        public AddMovie(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            //con_str= new SQL_Conn();
            //con_str.OpenConection();
            //SQL Queries
            //string connectionString = "Data Source=(local);Database=BLOCKBUSTER;Integrated Security=sspi;";
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server = LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int newMovieID;
            string lastMovieID;
            myCommand.CommandText = "select max(MovieID) as maxID from Movies;";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            lastMovieID = myReader["maxID"].ToString();
            newMovieID = Int32.Parse(lastMovieID) + 1;
            myReader.Close();


            MessageBox.Show($"New Movie ID: {newMovieID}");
            string newTitle, genre, fee, rating;
            myCommand.CommandText = $"insert into Movies values ({newMovieID},'{titleBox.Text}', '{genreBox.Text}', {feeBox.Text}, {ratingBox.Text}, {yearReleasedBox.Text});";

            try
            {
                myReader = myCommand.ExecuteReader();
                myReader.Close();
                MessageBox.Show($"{titleBox.Text} was inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }

            myCommand.CommandText = $"insert into Copies values (1, {newMovieID}, 'DVD', 1);" +
                                    $"insert into Copies values (2, {newMovieID}, 'Blu-Ray', 1);" +
                                    $"insert into Copies values (3, {newMovieID}, 'VHS', 1);";
            try
            {
                myReader = myCommand.ExecuteReader();
                myReader.Close();
                MessageBox.Show($"{titleBox.Text} copies were inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletesearchdatagrid.Rows.Clear();
            int newMovieID;
            string lastMovieID;
            if (idradio.Checked)
            {
                myCommand.CommandText = $"select * from Movies  where MovieID = {idDelete.Text}";
            }
            else if (titleradio.Checked){
                myCommand.CommandText = $"select * from Movies where Title like '%{titleDelete.Text.Trim()}%' ";
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    deletesearchdatagrid.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(),
                                                  myReader["Genre"].ToString(),
                                                  myReader["fee"].ToString(),
                                                  myReader["ReleaseYear"].ToString(), myReader["MovieRating"]);


                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (titleDelete.Enabled)
            {
                titleDelete.Enabled = false;
                titleDelete.Text = "";
            }
            else
            {
                titleDelete.Enabled = true;
            }
        }

        private void idradio_CheckedChanged(object sender, EventArgs e)
        {
            if (idDelete.Enabled)
            {
                idDelete.Enabled = false;
                idDelete.Text = "";
            }
            else
            {
                idDelete.Enabled = true;
            }
        }

        private void deletesearchdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            myCommand.CommandText = $"DELETE Movies where Movies.MovieID = {deletesearchdatagrid.CurrentCell.Value}";
            try
            {
                if (deletesearchdatagrid.Columns[e.ColumnIndex].Name == "MovieID")
                {       
                    
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Close();
                        MessageBox.Show($"Succesfully Deleted: {deletesearchdatagrid.CurrentRow.Cells["MovieName"].Value}");
                        deletesearchdatagrid.Rows.Clear();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show("Wrong cell selected");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong cell selected");
            }
        }
    }
}
