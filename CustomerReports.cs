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
    public partial class CustomerReports : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 EmpRep;
        public CustomerReports(Form1 frm)
        {
            EmpRep = frm;
            InitializeComponent();
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
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
                    /*
                    clientEmails.Rows.Add(myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim(),
                                          myReader["email"].ToString(), myReader["CustomerID"].ToString());
                    //MessageBox.Show(myReader["MovieName"].ToString());
                */
                    }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
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
            EmpRep.loadBigForms(new SalesReport(EmpRep));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
