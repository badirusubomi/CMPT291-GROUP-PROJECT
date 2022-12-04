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
    public partial class AddEmployee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;

        public AddEmployee(Form1 frm)
        {
            InitializeComponent();
            employeeEditConfirmButton.Hide();
            ths = frm;
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
           

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");
                
                if (this.idSearch.Text.ToString() != "") {
                    employeeEditConfirmButton.Show();
                    myCommand.CommandText = $"Select * from Employee as E where E.EmployeeID = {this.idSearch.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        employeeIDEdit.Text = myReader["EmployeeID"].ToString();
                        employeeEditFNameLabel.Text = myReader["FName"].ToString();
                        employeeEditLNameLabel.Text = myReader["LName"].ToString();
                        employeeEditEmailLabel.Text = myReader["Email"].ToString();
                        employeeEditPasswordLabel.Text = myReader["Passwords"].ToString();
                        employeeEditStateLabel.Text = myReader["Province"].ToString();
                        employeeEditCityLabel.Text = myReader["City"].ToString();
                        employeeEditPostalLabel.Text = myReader["ZipCode"].ToString();
                        
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please type ID to search for");
                }
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                myCommand.CommandText = $"Select * from Employee as E where E.EmployeeID = {idSearch.Text}";
                if (idSearch.Text.ToString() != "")
                {
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
                }
                else
                {
                    MessageBox.Show("Please type ID to search for");
                }
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
