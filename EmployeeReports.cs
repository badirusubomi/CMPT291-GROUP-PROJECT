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
    public partial class EmployeeReports : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 EmpRep;
        //SQL_Conn con_str;
        public EmployeeReports(Form1 frm)
        {
            InitializeComponent();
            EmpRep = frm;
            //con_str= new SQL_Conn();
            //con_str.OpenConection();
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            dataGridView1.Rows.Clear();

            //Start Queries
            myCommand.CommandText = $"select * from Employee";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]} {myReader["ZipCode"]}",
                                          myReader["StartDate"].ToString(), myReader["Wage"].ToString());
                   
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void reLoad(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            myCommand.CommandText = $"select * from Employee";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]} {myReader["ZipCode"]}",
                                          myReader["StartDate"].ToString(), myReader["Wage"].ToString());

                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
        
        
        private int checkCounter;
        private void OnCheckedChanged(object sender, EventArgs e)
        {
            // Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;

            // prevent checking
            if (checkCounter == 2)
            {
                MessageBox.Show("Max 1 options:", "Please select 1 search option only");
                box.Checked = false;
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpRep.loadBigForms(new SalesReport(EmpRep));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void adrCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
           
        }

        private void emailCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            
        }

        private void inhandCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
           
        }

        private void planCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
           
        }

        private void mCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            
        }

        private void fCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            
        }

        private void srcBT_Click(object sender, EventArgs e)
        {
            string order = "";
            if (ordCO.Text == "Ascending")
            {
                order = "ASC";
            }
            else if (ordCO.Text == "Descending")
            {
                order = "DESC";
            }

            if (adrCB.Checked)
            {
                myCommand.CommandText = $"select EmployeeID, FName, LName, concat(Street, City, Province, ZipCode) as Address from Employee order by Address  {order}";
                if (order == "") myCommand.CommandText = $"select EmployeeID, FName, LName, concat(Street, City, Province, ZipCode) as Address from Employee order by EmployeeID";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            "", "", myReader["Address"].ToString());
                    myReader.Close();
                    adrCB.Checked = false;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (emailCB.Checked)
            {
                myCommand.CommandText = $"select EmployeeID, FName, LName, Email from Employee order by email {order}";
                if (order == "") myCommand.CommandText = $"select EmployeeID, FName, LName, Email from Employee order by EmployeeID ";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            myReader["Email"].ToString());
                    myReader.Close();
                    emailCB.Checked = false;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (salCB.Checked)
            { 
                myCommand.CommandText = $"select EmployeeID, FName, LName, Wage from Employee order by Wage {order}";
                if (order == "") myCommand.CommandText = $"select EmployeeID, FName, LName, Wage from Employee order by EmployeeID";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            "", "", "", "", myReader["Wage"].ToString());
                    myReader.Close();
                    salCB.Checked = false;

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (sdateCB.Checked)
            {   
                myCommand.CommandText = $"select EmployeeID, FName, LName, StartDate from Employee order by StartDate {order}";
                
                if (order == "") myCommand.CommandText = $"select EmployeeID, FName, LName, StartDate from Employee order by EmployeeID";
               
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            "", "", "", myReader["StartDate"].ToString(),"");
                    myReader.Close();
                    sdateCB.Checked = false;    

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (mCB.Checked)
            {
                myCommand.CommandText = $"select  * from Employee where Gender ='M'";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]} {myReader["ZipCode"]}",
                                          myReader["StartDate"].ToString(), myReader["Wage"].ToString());
                    myReader.Close();
                    mCB.Checked = false;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (fCB.Checked)
            {
                myCommand.CommandText = $"select  * from Employee where Gender ='F'";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["EmployeeID"].ToString(),
                            myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]} {myReader["ZipCode"]}",
                                          myReader["StartDate"].ToString(), myReader["Wage"].ToString());
                    myReader.Close();
                    fCB.Checked = false;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            ordCO.SelectedIndex = -1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            reLoad(sender,e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
