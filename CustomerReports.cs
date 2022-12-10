using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class CustomerReports : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 CusRep;
        //SQL_Conn con_str;
        public CustomerReports(Form1 frm)
        {
            CusRep = frm;
            InitializeComponent();
            //con_str= new SQL_Conn();
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            //con_str.OpenConection();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            dataGridView1.Rows.Clear();
            
            //Start Queries
            myCommand.CommandText = $"select * from Customer";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                          myReader["PlanID"].ToString(), myReader["inHand"].ToString());                   
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
            if (checkCounter == 3)
            {
                MessageBox.Show("Max 2 options:", "Please select 2 search option only");
                box.Checked = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CusRep.loadBigForms(new SalesReport(CusRep));
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        
        private void nmeCB_CheckedChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void reLoad(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            myCommand.CommandText = $"select * from Customer";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                          myReader["PlanID"].ToString(), myReader["inHand"].ToString());

                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void CustomerReports_Load(object sender, EventArgs e)
        {

        }

        private void mCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
            
            

        }

        private void fCB_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reLoad(sender, e);
        }

        private void apBT_Click(object sender, EventArgs e)
        {
            if (adrRB.Checked)
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, concat(Street, City, Province) as Address from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(), "", "", myReader["Address"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            
            if (emRB.Checked)
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, Email from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(), myReader["Email"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (ihRB.Checked)
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, inHand from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(), "", "", "", "", myReader["inHand"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (plRB.Checked)
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, PlanID from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(), "", "", "", myReader["PlanID"].ToString(), "");
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (mRB.Checked)
            {
                myCommand.CommandText = $"select  * from Customer where Gender ='M'";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                          myReader["PlanID"].ToString(), myReader["inHand"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (fRB.Checked)
            {
                myCommand.CommandText = $"select  * from Customer where Gender ='F'";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                             myReader["email"].ToString(), myReader["Gender"].ToString(),
                                          $"{myReader["Street"]} {myReader["City"]} {myReader["Province"]}",
                                          myReader["PlanID"].ToString(), myReader["inHand"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if (sdRB.Checked)
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, CreationDate from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            "", "", "", "", "", myReader["CreationDate"].ToString(), "");
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            if(edRB.Checked) 
            {
                myCommand.CommandText = $"select CustomerID, FName, LName, ExpiryDate from Customer";
                dataGridView1.Rows.Clear();
                try
                {
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                        dataGridView1.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                            "", "", "","" , "", "", myReader["ExpiryDate"].ToString());
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

