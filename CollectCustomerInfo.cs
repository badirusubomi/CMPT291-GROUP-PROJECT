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
    public partial class CollectCustomerInfo : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public CollectCustomerInfo(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            ContinueRental.Hide();
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
            ths.loadBigForms(new FindMovieEmployee(ths, collectCustomerID.Text));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            int PlanLimit = 0;
            int customerInHand = 0;


            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.collectCustomerIDSearch.Text.ToString() != "")
                {

                    myCommand.CommandText = $"Select * from Customer as C where C.CustomerID = {this.collectCustomerIDSearch.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        collectCustomerID.Text = myReader["CustomerID"].ToString();
                        collectCustomerName.Text = myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim();
                        collectCustomerPlanExpiry.Text = myReader["ExpiryDate"].ToString();
                        collectCustomerEmail.Text = myReader["Email"].ToString().Trim();
                        collectCustomerPlanType.Text = myReader["PlanID"].ToString().Trim();
                        customerInHand = Int32.Parse(myReader["inHand"].ToString().Trim());


                        myReader.Close();
                        try
                        {
                            myCommand.CommandText = $"select PlanLimit from AccType where PlanID = {collectCustomerPlanType.Text}";
                            myReader = myCommand.ExecuteReader();
                            myReader.Read();

                            PlanLimit = Int32.Parse(myReader["PlanLimit"].ToString());
                            collectCustomerCheckOutLimit.Text = PlanLimit.ToString();
                            if (customerInHand < PlanLimit)
                            {
                                ContinueRental.Show();
                            }
                            else
                            {
                                MessageBox.Show("User has reached limit, Update Plan or Return Movie", "Limit Reached");
                            }
                        }
                        catch (Exception e3){
                            MessageBox.Show(e3.ToString(), "Error");
                        }


                        
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert ID to attempt delete");
                }
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void ContinueRental_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new FindMovieEmployee(ths, collectCustomerID.Text));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
