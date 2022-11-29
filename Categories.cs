using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT291_GROUP_PROJECT
{
    public partial class Categories : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public Categories(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            //string connectionString = "Data Source=(local);Database=BLOCKBUSTER;Integrated Security=sspi;";
            //string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            string connectionString = "Server = LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                Console.WriteLine("Succesfully Connected");
                MessageBox.Show("Succesfully Connected");

                //Start Queries
                
                //Action
                myCommand.CommandText = "select * from Movies where MovieType = 'Action'";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    actionMovies.Rows.Clear();
                    while (myReader.Read())
                    {
                        actionMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                        //MessageBox.Show(myReader["MovieName"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                //Drama
                myCommand.CommandText = "select * from Movies where MovieType = 'Drama'";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    dramaMovies.Rows.Clear();
                    while (myReader.Read())
                    {
                        dramaMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                        //MessageBox.Show(myReader["MovieName"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                //Thriller
                myCommand.CommandText = "select * from Movies where MovieType = 'Thriller'";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    thrillerMovies.Rows.Clear();
                    while (myReader.Read())
                    {
                        thrillerMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                //Documentary
                myCommand.CommandText = "select * from Movies where MovieType = 'Documentary'";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    documentaryMovies.Rows.Clear();
                    while (myReader.Read())
                    {
                        documentaryMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ths.showForms(ths);
            ths.loadForms(new searchform(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            myCommand.CommandText = "select * from Movies where MovieType = 'Action'";
            try
            {
                myReader = myCommand.ExecuteReader();
                actionMovies.Rows.Clear();
                while (myReader.Read())
                {
                    actionMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                    //MessageBox.Show(myReader["MovieName"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            */
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dramaMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            myCommand.CommandText = "select * from Movies where MovieType = 'Drama'";
            try
            {
                myReader = myCommand.ExecuteReader();
                dramaMovies.Rows.Clear();
                while (myReader.Read())
                {
                    dramaMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                    //MessageBox.Show(myReader["MovieName"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            */
        }

        private void comedyMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            myCommand.CommandText = "select * from Movies where MovieType = 'Comedy'";
            try
            {
                myReader = myCommand.ExecuteReader();
                comedyMovies.Rows.Clear();
                while (myReader.Read())
                {
                    comedyMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                    //MessageBox.Show(myReader["MovieName"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            */
        }

        private void documentaryMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            myCommand.CommandText = "select * from Movies where MovieType = 'Documentary'";
            try
            {
                myReader = myCommand.ExecuteReader();
                documentaryMovies.Rows.Clear();
                while (myReader.Read())
                {
                    documentaryMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            */
        }

        private void thrillerMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            myCommand.CommandText = "select * from Movies where MovieType = 'Thriller'";
            try
            {
                myReader = myCommand.ExecuteReader();
                thrillerMovies.Rows.Clear();
                while (myReader.Read())
                {
                    thrillerMovies.Rows.Add(myReader["MovieID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["fee"].ToString(), myReader["MovieRating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            */
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }
    }
}
