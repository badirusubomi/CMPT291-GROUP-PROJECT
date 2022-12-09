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
    public partial class ProfilePage : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        SQL_Conn con_str;
        Form1 ths;
        public ProfilePage(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            con_str.OpenConection();
            this.button7.Hide();
            this.button8.Hide();
            this.button9.Hide();

            //string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show($"Username: {ths.AppUser._email}");   Dev. Check
            try
            {
                //myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;

                //Start Queries
                //Get Orders
                myCommand.CommandText = $"select Customer.CustomerID as ID from Customer where Customer.email = '{ths.AppUser._email}'";
                //MessageBox.Show(ths.AppUser._email.ToString());
                
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                string accountID = myReader["ID"].ToString();
                //MessageBox.Show(accountID);
                myReader.Close();
                

                myCommand.CommandText = $"select * from Orders, Movies where Orders.MovieID = Movies.MovieID and Orders.CustomerID = {accountID}";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        
                        orderHistory.Rows.Add(myReader["OrderID"].ToString(), myReader["CopyID"].ToString(), myReader["Title"].ToString(), 
                                              myReader["DateFrom"].ToString(), myReader["DateTo"].ToString(), myReader["OrderStatus"].ToString());

                        //MessageBox.Show(myReader["Title"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                

                //Add Customer info to account info page
                myCommand.CommandText = $"select * from Customer where Customer.email = '{ths.AppUser._email}'";
                myReader = myCommand.ExecuteReader();
                try
                {
                    myReader.Read();
                    customerID.Text = $"{myReader["CustomerID"]}".Trim();
                    accountType.Text = $"{myReader["PlanID"]}";
                    Address.Text = $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}";
                    gender.Text = myReader["Gender"].ToString();
                    email.Text = myReader["email"].ToString();
                    accountCreationDate.Text = myReader["CreationDate"].ToString();
                    balance.Text = myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountType_Click(object sender, EventArgs e)
        {

        }
    }
}
