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
    public partial class ProcessReturnsPage : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        
        Form1 ths;
        //SQL_Conn con_str;
        public ProcessReturnsPage(Form1 frm)
        {
            ths = frm;
           // con_str= new SQL_Conn();
            InitializeComponent();
           // con_str = new SQL_Conn();
            //SQL Queries
            //string connectionString = "Data Source=(local);Database=BLOCKBUSTER;Integrated Security=sspi;";
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server = LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            //con_str.OpenConection();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }

        private void titleradio_CheckedChanged(object sender, EventArgs e)
        {
            if (titleDelete.Enabled)
            {
                titleDelete.Enabled = false;
                titleDelete.Text = "";
            }
            else
            {
                titleDelete.Enabled = true;
            }
        }

        private void idradio_CheckedChanged(object sender, EventArgs e)
        {
            if (idDelete.Enabled)
            {
                idDelete.Enabled = false;
                idDelete.Text = "";
            }
            else
            {
                idDelete.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletesearchdatagrid.Rows.Clear();
            int newMovieID;
            string lastMovieID;
            if (titleradio.Checked)
            {
                myCommand.CommandText = $"select * from Orders, Movies as M1  where OrderID = " +
                                        $"{titleDelete.Text} and M1.MovieID = Orders.MovieID";
            }
            else if (idradio.Checked)
            {
                myCommand.CommandText = $"select * from Orders, Movies as M1 where CustomerID = " +
                                        $"{idDelete.Text} and M1.MovieID = Orders.MovieID";
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    deletesearchdatagrid.Rows.Add(myReader["OrderID"].ToString(),
                                                  myReader["CustomerID"].ToString(),
                                                  myReader["MovieID"].ToString(),
                                                  myReader["CopyID"].ToString(),
                                                  myReader["Title"].ToString(), 
                                                  myReader["OrderStatus"].ToString(), 
                                                  myReader["DateFrom"].ToString(),
                                                  myReader["DateTo"],ToString());


                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Enter ID", "Error");
            }
        }

        private void deletesearchdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            myCommand.CommandText = $"UPDATE Orders " +
                                    $"SET OrderStatus = 1 WHERE OrderID =  {deletesearchdatagrid.CurrentCell.Value} ";

            try
            {
                if (deletesearchdatagrid.Columns[e.ColumnIndex].Name == "OrderID")
                {

                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                    myCommand.CommandText = $"UPDATE CUSTOMER " +
                                            $"SET inHand = inHand - 1 WHERE " +
                                            $"CustomerID = {deletesearchdatagrid.CurrentRow.Cells["CustomerID"].Value}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        myReader.Close();
                        MessageBox.Show("Succesfully Updated Customer Table");
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }

                    MessageBox.Show($"Succesfully Returned: {deletesearchdatagrid.CurrentRow.Cells["MovieName"].Value}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong cell selected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void ProcessReturnsPage_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
