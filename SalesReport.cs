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
    public partial class SalesReport : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public SalesReport(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
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
                /*
                //Start Queries
                myCommand.CommandText = $"select * from Customer";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        CustomerData.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(), 
                                              myReader["PlanID"].ToString(), $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                              myReader["email"].ToString());
                        clientEmails.Rows.Add(myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                              myReader["email"].ToString(), myReader["CustomerID"].ToString());
                        //MessageBox.Show(myReader["MovieName"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

                //Getting Employee Data
                myCommand.CommandText = $"select * from Employee";
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        EmployeeData.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                              myReader["email"].ToString(), $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                              myReader["Gender"].ToString(), myReader["Wage"].ToString());                        
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                //End Queries*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"{CustomerData.Row.}{}");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ths.loadBigForms(new CustomerReports(ths));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeReports(ths));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
