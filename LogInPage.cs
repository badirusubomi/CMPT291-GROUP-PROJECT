using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class LogInPage : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;
        public LogInPage(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
            //string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            //Console.WriteLine("Succesfully Connected");
            //MessageBox.Show("Succesfully Connected");
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;

                //Start Queries

                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            ths.AppUser = new User();
            ths.AppUser._email = Username.Text;
            bool logIncheck = false;
            string tempPassword;
            //MessageBox.Show($"Email: {ths.AppUser._email}");      Dev. check
            
            if (employeeRadio.Checked)
            {

                myCommand.CommandText = $"select E.Passwords as password, E.EmployeeID as EID from Employee as E where E.email = '{Username.Text}'";

                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        //MessageBox.Show(myReader["MovieName"].ToString());
                        tempPassword = myReader["password"].ToString();
                        //MessageBox.Show($"Email: {ths.AppUser._email}\nCorrect Password: {tempPassword}"); //Dev.check
                        if (Password.Text == tempPassword)
                        {
                            logIncheck = true;
                            ths.AppUser.ID = Int32.Parse(myReader["EID"].ToString());
                            //MessageBox.Show($"Email: {ths.AppUser._email}\nCorrect Password: {tempPassword}\nID: {ths.AppUser.ID}"); //Dev.check
                        }
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                if (logIncheck) {
                    ths.loadBigForms(new EmployeeWelcomePage(ths));
                }
            }
            else
            {
                myCommand.CommandText = $"select C.Passwords as password, C.CustomerID as CID from Customer as C where C.email = '{Username.Text}'";

                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        tempPassword = myReader["password"].ToString();
                        //MessageBox.Show($"Email: {ths.AppUser._email}\nCorrect Password: {tempPassword}"); //Dev.check
                        if (Password.Text == tempPassword)
                        {
                            logIncheck = true;
                            ths.AppUser.ID = Int32.Parse(myReader["CID"].ToString());
                            //MessageBox.Show($"Email: {ths.AppUser._email}\nCorrect Password: {tempPassword}\nID: {ths.AppUser.ID}"); //Dev.check
                        }
                        //MessageBox.Show(myReader["MovieName"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
                if (logIncheck)
                {
                    ths.showForms(ths);
                    ths.loadForms(new searchform(ths));
                }
                else
                {
                    ths.loadBigForms(new LogInPage(ths));
                }
                //ths.showForms(ths);
                //ths.loadForms(new searchform(ths));
                //ths.loadBigForms(new LogInPage(ths));
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
