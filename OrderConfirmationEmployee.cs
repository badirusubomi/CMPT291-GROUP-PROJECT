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
    public partial class OrderConfirmationEmployee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        string movieID;
        public OrderConfirmationEmployee(Form1 frm, string dateFromf, string dateTof, string customerIDf, string movieIDfrm)
        {
            ths = frm;
            InitializeComponent();
            button2.Hide();


            DateTo.Text = dateTof;
            DateFrom.Text = dateFromf;
            CustomerID.Text = customerIDf;
            title.Text = ths.AppUser._selectTitle;
            CopyID.Text = ths.AppUser._selectMovie;
            movieID = movieIDfrm;

            //SQL begins;
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            int temporderID = 0;
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //MessageBox.Show($"Query: {ths.AppUser._query}");
                //Start Queries
               
                try
                {
                    myCommand.CommandText = "select max(OrderID) as maxID from Orders;";
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    string strtemporderID = myReader["maxID"].ToString();
                    temporderID = Int32.Parse(strtemporderID) + 1;
                    MessageBox.Show(temporderID.ToString());
                    orderID.Text = temporderID.ToString();

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
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //MessageBox.Show($"Query: {ths.AppUser._query}");
                //Start Queries

                //create order
                myCommand.CommandText = $"Insert into Orders values " +
                                        $"({orderID.Text}, {CustomerID.Text}, {ths.AppUser._ID}, {ths.AppUser._selectMovie}, {movieID}, '{DateFrom.Text}', '{DateTo.Text}', 0);";
                try 
                {
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                // update inHand for Customer
                myCommand.CommandText = $"UPDATE Customer SET inHand = inHand + 1 where Customer.CustomerID = {CustomerID.Text}";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                //update Order status in Copy
                myCommand.CommandText = $"UPDATE Copies SET OrderStatus = 0 where Copies.CopyID = {CopyID.Text}" +
                                        $" and MovieID = {movieID}";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                button1.PerformClick();
                //ETC;

                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
