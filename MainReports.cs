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
    public partial class MainReports : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 MainRep;
        SQL_Conn con_str;
        public MainReports(Form1 frm)
        {
            MainRep = frm;
            InitializeComponent();
            con_str= new SQL_Conn();
            con_str.OpenConection();
            //string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //string connectionString = "Server =LAPTOP-UN5MBSMV;Database=BLOCKBUSTER;Trusted_connection = yes;";
            //SqlConnection myConnection = new SqlConnection(connectionString);
            //myConnection.Open();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            dataGridView1.Rows.Clear();

            myCommand.CommandText = $"select * from Orders";
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["OrderID"].ToString(), myReader["EmployeeID"].ToString(), myReader["CustomerID"].ToString(),
                        myReader["CopyID"].ToString(), myReader["MovieID"].ToString(), myReader["DateFrom"].ToString(),
                        myReader["DateTo"].ToString(), myReader["OrderStatus"].ToString());
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            
        }
        private void DailyEmpty(object sender, EventArgs e)
        {
            MessageBox.Show( "Not enough Records to generate", "Error");           
            renRB.Checked = false;
            mvRB.Checked = false;

            //dyCB.SelectedIndex = -1;
            mthCB.SelectedIndex = -1;
            yrCB.SelectedIndex = -1;          
        }

        private void StatsEmpty(object sender, EventArgs e)
        {
            MessageBox.Show("Not enough Records to generate", "Error");
            empRB.Checked = false;
            cusRB.Checked = false;
            odRB.Checked = false;
           
            //dyCB.SelectedIndex = -1;
            mthCB.SelectedIndex = -1;
            yrCB.SelectedIndex = -1;           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainRep.loadBigForms(new SalesReport(MainRep));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  mth = "", yr = "";
            int mflag = 0 , yflag = 0;

           
            if (mthCB.SelectedIndex != -1)
            {
                mflag = 1;
                mth = mthCB.Text;

            }
            if (yrCB.SelectedIndex != -1)
            {
                yflag = 1;
                yr = yrCB.Text;

            }

            if (yflag == 0) yr = DateTime.Now.Year.ToString();
            if (mflag == 0) mth = DateTime.Now.Month.ToString();

            if ( (mflag != 0) && (yflag != 0) )
            { //string dt = $"{yr}\\{mth}\\{dy}";
                if (renRB.Checked)
                {
                    myCommand.CommandText = $"select count(*) as Counts from Orders where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr}";

                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows)
                    {
                        DailyEmpty(sender, e);

                    }
                    while(myReader.Read())
                    {
                        dailyG.Rows.Add("","",myReader["Counts"].ToString());
                    }
                }
                else if (mvRB.Checked)
                {
                    myCommand.CommandText = $"select  M.MovieID,M.Title, T.Counts from Movies as M ,(select MovieID, count(*) as Counts from Orders" +
                        $" where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr} group by MovieID) " +
                        $"as T where T.MovieID = M.MovieID";
                    
                    myReader = myCommand.ExecuteReader();                    
                    if (!myReader.HasRows) DailyEmpty(sender, e);
                    while (myReader.Read())
                    {
                        dailyG.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(), myReader["Counts"].ToString());
                    }
                    myReader.Close();
                }

            }
        
            else if ((mflag != 0) && (yflag != 0))
            {
                
                if (renRB.Checked)
                {
                    myCommand.CommandText = $"select count(*) from Orders where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr}";
                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows) DailyEmpty(sender, e);
                    while (myReader.Read())
                    {
                        dailyG.Rows.Add("", "", myReader["Counts"].ToString());
                    }
                }
                else if (mvRB.Checked)
                {
                    myCommand.CommandText = $"select M.MovieID, M.Title, T.Counts from Movies as M ,(select MovieID, count(*) as Counts from Orders " +
                        $"where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr} group by MovieID) as T where T.MovieID = M.MovieID";
                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows) DailyEmpty(sender, e);
                    while (myReader.Read())
                    {
                        dailyG.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(), myReader["Counts"].ToString());
                    }
                }
            }
        }

        private void gen2BT_Click(object sender, EventArgs e)
        {
            string  mth = "", yr = "";
            int  mflag = 0, yflag = 0;
           
            if (mthCB.SelectedIndex != -1)
            {
                mflag = 1;
                mth = mthCB.Text;

            }
            if (yrCB.SelectedIndex != -1)
            {
                yflag = 1;
                yr = yrCB.Text;

            }

            if (yflag == 0) yr = DateTime.Now.Year.ToString();
            //if (mflag == 0) mth = DateTime.Now.Month.ToString();

            if ((mflag != 0) && (yflag != 0))
            {
                if (empRB.Checked)
                {
                    myCommand.CommandText = $"select T.EmployeeID, E.FName, T.Sales from Employee as E, (select EmployeeID, count(*) as Sales from Orders" +
                        $" where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr} group by EmployeeID) as T" +
                        $"where T.EmployeeID = E.EmployeeID";
                    
                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows) StatsEmpty(sender, e);
                    while (myReader.Read())
                    {
                        statsG.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                    }
                    
                    myReader.Close();
                }
                else if (cusRB.Checked)
                {
                    myCommand.CommandText = $"select T.CustomerID C.FName, T.Sales from Customer as C,(select CustomerID, count(*) as Sales from Orders" +
                        $" where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr} group by CustomerID) as T where T.CustomerID = C.CustomerID ";

                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows) StatsEmpty(sender, e);
                    while (myReader.Read())
                    {
                        statsG.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                    }
                    myReader.Close();
                }
                else if (odRB.Checked)
                {
                    myCommand.CommandText = $"select T.CustomerID, C.FName, T.Sales from Customer as C,(select CustomerID, count(*) as Sales from Orders " +
                        $"where MONTH(DateFrom) = {mth} AND YEAR(DateFrom) = {yr} AND OrderStatus = 2 group by CustomerID) as T " +
                        $"where T.CustomerID = C.CustomerID ";

                    myReader = myCommand.ExecuteReader();
                    if (!myReader.HasRows) StatsEmpty(sender, e);
                    while (myReader.Read())
                    {
                        statsG.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                    }
                    myReader.Close();
                }
            else if ( yflag!= 0 ) 
                {
                    if (empRB.Checked)
                    {
                        myCommand.CommandText = $"select T.EmployeeID ,Employee.FName, T.Sales from Employee as E, (select EmployeeID, count(*) as Sales from Orders" +
                            $" where YEAR(DateFrom) = {yr} group by EmployeeID) as T" +
                            $"where T.EmployeeID = E.EmployeeID";

                        myReader = myCommand.ExecuteReader();
                        if (!myReader.HasRows) StatsEmpty(sender, e);
                        while (myReader.Read())
                        {
                            statsG.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                        }
                        myReader.Close();
                    }
                    else if (cusRB.Checked)
                    {
                        myCommand.CommandText = $"select T.CustomerID, C.FName, T.Sales from Customer as C,(select CustomerID, count(*) as Sales from Orders" +
                            $" where YEAR(DateFrom) = {yr} group by CustomerID) as T where T.CustomerID = C.CustomerID ";
                        
                        myReader = myCommand.ExecuteReader();
                        if (!myReader.HasRows) StatsEmpty(sender, e);
                        while (myReader.Read())
                        {
                            statsG.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                        }
                        myReader.Close();
                    }
                    else if (odRB.Checked)
                    {
                        myCommand.CommandText = $"select T.CustomerID, C.FName, T.Sales from Customer as C,(select CustomerID, count(*) as Sales from Orders " +
                            $"where YEAR(DateFrom) = {yr} AND OrderStatus = 2 group by CustomerID) as T " +
                            $"where T.CustomerID = C.CustomerID ";
                        
                        myReader = myCommand.ExecuteReader();
                        if (!myReader.HasRows) StatsEmpty(sender, e);
                        while (myReader.Read())
                        {
                            statsG.Rows.Add(myReader["CustomerID"].ToString(), myReader["FName"].ToString(), myReader["Sales"].ToString());
                        }
                        myReader.Close();
                    }
                }
               
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
