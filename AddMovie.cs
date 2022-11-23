using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public AddMovie(Form1 frm)
        {
            ths = frm;
            InitializeComponent();

            //SQL Queries
            //string connectionString = "Data Source=(local);Database=BLOCKBUSTER;Integrated Security=sspi;";
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                Console.WriteLine("Succesfully Connected");
                //MessageBox.Show("Succesfully Connected");

                //Start Queries

                
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
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
            myCommand.CommandText = $"insert into Movies values ({newMovieID},'{titleBox.Text}', '{genreBox.Text}', {feeBox.Text}, {ratingBox.Text});";
            myReader = myCommand.ExecuteReader();
            myReader.Close();
            MessageBox.Show($"{titleBox.Text} was inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int newMovieID;
            string lastMovieID;

            myCommand.CommandText = $"DELETE FROM Movies  where MovieID = {idDelete.Text} or MovieName = '{titleDelete.Text}';";
            myReader = myCommand.ExecuteReader();
            myReader.Close();
            MessageBox.Show($"{titleDelete.Text} was deleted");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
