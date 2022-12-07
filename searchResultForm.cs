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
    public partial class searchResultForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public searchResultForm(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            SelectMovie.Hide();
            SelectMovie.Click += new EventHandler(SelectMovie_Click);
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //MessageBox.Show($"Query: {ths.AppUser._query}");
                //Start Queries
                myCommand.CommandText = ths.AppUser._query;
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        searchResult.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(), 
                                              myReader["Genre"].ToString(), myReader["ReleaseYear"].ToString(), 
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

        private void searchResultForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectMovie_Click(object sender, EventArgs e)
        {
            ths.loadForms(new PresentCopies(ths));
        }

        private void searchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searchResult.Columns[e.ColumnIndex].Name == "ID")
            {
                ths.AppUser._selectMovie = searchResult.CurrentCell.Value.ToString();
                ths.AppUser._selectTitle = searchResult.CurrentRow.Cells["Title"].Value.ToString();
                //MessageBox.Show($"Movie Title: {ths.AppUser._selectTitle}");
                SelectMovie.Show();
                SelectMovie.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
