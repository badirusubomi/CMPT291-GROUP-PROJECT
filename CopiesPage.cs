using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class PresentCopies : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public PresentCopies(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            RentButton.Hide();
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            string movieID = ths.AppUser._selectMovie;
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show($"Movie to find: {ths.AppUser._selectMovie}");

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                myCommand.CommandText = $"Select * from Copies as C, Movies as M where C.MovieID = M.MovieID and " +
                                        $"M.MovieID = {movieID} and C.CopyID not in" +
                                        $"(Select distinct O.CopyID from Orders as O where O.OrderStatus =  0 or O.OrderStatus = 2)  ";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        CopyTable.Rows.Add(myReader["CopyID"].ToString(), myReader["Title"].ToString(),
                                              myReader["CopyType"].ToString());

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

        private void RentButton_Click(object sender, EventArgs e)
        {
            ths.loadForms(new CheckOutPage(ths));
        }

        private void PresentCopies_Load(object sender, EventArgs e)
        {

        }

        private void CopyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CopyTable.Columns[e.ColumnIndex].Name == "CopyID")
            {
                ths.AppUser._selectMovie = CopyTable.CurrentCell.Value.ToString();
                RentButton.PerformClick();
                ths.loadForms(new CheckOutPage(ths));
            }
        }
    }
}
