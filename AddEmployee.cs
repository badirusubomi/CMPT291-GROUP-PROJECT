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
    public partial class AddEmployee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Form1 ths;


        /*****
         *      code to re-use
         * ===================
         * $"SET EmployeeID = {employeeIDEdit.Text}, FName = '{employeeEditFNameLabel.Text}', " +
                                            $"LName = '{employeeEditLNameLabel.Text}', Email = '{employeeEditEmailLabel.Text}'," +
                                            $" Gender = '{employeeEditGenderLabel.Text}', Street = '{employeeEditStreetLabel.Text}'," +
                                            $" City = '{employeeEditCityLabel.Text}', Province = '{employeeEditStateLabel.Text}', " +
                                            $"ZipCode = '{employeeEditPostalLabel.Text}',Wage = {employeeEditWageLabel.Text}, " +
                                            $"Passwords = '{employeeEditPasswordLabel.Text}' WHERE EmployeeID = {employeeIDEdit.Text};";
        ========================================

        string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            if (employeeAddID.Text != null && employeeAddFname.Text != null && employeeAddPassword.Text != null)
            {
                try
                {
                    myConnection.Open();
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                    //Start Queries
                    myCommand.CommandText = $"insert into Employee values ({employeeAddID.Text}, '{employeeAddFname.Text}','{employeeAddLname.Text}','{employeeAddEmail.Text}'," +
                                            $"'{employeeAddGender.Text}','{employeeAddStreet.Text}', '{employeeAddCity.Text}','{employeeAddState.Text}', " +
                                            $"'{employeeAddPostal.Text}', '{employeeAddStartFrom.Text}', {employeeAddWage.Text}, '{employeeAddPassword.Text}');";
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
                    //End Queries
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill out EmployeeID and First Name box");
            }

        =============================

        myReader["FName"].ToString().Trim()
        ====================================

        if (employeeIDEdit.Text != null && employeeEditFNameLabel.Text != null)
            {
                try
                {
                    myConnection.Open();
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                    //Start Queries
                    myCommand.CommandText = $"SET EmployeeID = {employeeIDEdit.Text}, FName = {employeeEditFNameLabel.Text}, " +
                                            $"LName = {employeeEditLNameLabel.Text}, Email = {employeeEditEmailLabel.Text}," +
                                            $" Gender = {employeeEditGenderLabel.Text}, Street = {employeeEditStreetLabel.Text}," +
                                            $" City = {employeeEditCityLabel.Text}, Province = {employeeEditStateLabel.Text}, " +
                                            $"ZipCode = {employeeEditPostalLabel.Text},Wage = {employeeEditWageLabel.Text}, " +
                                            $"Passwords = {employeeEditPasswordLabel.Text} WHERE CustomerID = {idSearch.Text};";
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
                    //End Queries
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill out EmployeeID and First Name box");
            }



        ==================================================



         * 
         * 
         * 
         * 
         */



        public AddEmployee(Form1 frm)
        {
            InitializeComponent();
            employeeEditConfirmButton.Hide();
            employeeDeleteButton.Hide();
            customerEditConfirmButton.Hide();
            customerAddButton.Hide();
            customerDeleteButton.Hide();
            ths = frm;
           

            
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
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");
                
                if (this.idSearch.Text.ToString() != "") {
                    
                    myCommand.CommandText = $"Select * from Employee as E where E.EmployeeID = {this.idSearch.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        employeeIDEdit.Text = myReader["EmployeeID"].ToString().Trim();
                        employeeEditFNameLabel.Text = myReader["FName"].ToString().Trim();
                        employeeEditLNameLabel.Text = myReader["LName"].ToString().Trim();
                        employeeEditEmailLabel.Text = myReader["Email"].ToString().Trim();
                        employeeEditPasswordLabel.Text = myReader["Passwords"].ToString().Trim();
                        employeeEditStateLabel.Text = myReader["Province"].ToString().Trim();
                        employeeEditCityLabel.Text = myReader["City"].ToString().Trim();
                        employeeEditPostalLabel.Text = myReader["ZipCode"].ToString().Trim();
                        employeeEditWageLabel.Text = myReader["Wage"].ToString().Trim();
                        employeeEditGenderLabel.Text = myReader["Gender"].ToString().Trim();
                        employeeEditStreetLabel.Text = myReader["Street"].ToString().Trim();
                        employeeEditConfirmButton.Show();

                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show("User not Found, try again", "Error");
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

            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                myCommand.CommandText = $"UPDATE EMPLOYEE " +
                                        $"SET EmployeeID = {employeeIDEdit.Text}, FName = '{employeeEditFNameLabel.Text}', " +
                                        $"LName = '{employeeEditLNameLabel.Text}', Email = '{employeeEditEmailLabel.Text}'," +
                                        $" Gender = '{employeeEditGenderLabel.Text}', Street = '{employeeEditStreetLabel.Text}'," +
                                        $" City = '{employeeEditCityLabel.Text}', Province = '{employeeEditStateLabel.Text}', " +
                                        $"ZipCode = '{employeeEditPostalLabel.Text}',Wage = {employeeEditWageLabel.Text}, " +
                                        $"Passwords = '{employeeEditPasswordLabel.Text}' WHERE EmployeeID = {employeeIDEdit.Text};";
                if (employeeIDEdit.Text.ToString() != "")
                {
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        myReader.Close();
                        MessageBox.Show("Edit Success");

                        // Re-usable code section set everything to "" and hide Button

                        idSearch.Text = "";
                        employeeIDEdit.Text = "";
                        employeeEditFNameLabel.Text = "";
                        employeeEditLNameLabel.Text = "";
                        employeeEditEmailLabel.Text = "";
                        employeeEditPasswordLabel.Text = "";
                        employeeEditStateLabel.Text = "";
                        employeeEditCityLabel.Text = "";
                        employeeEditPostalLabel.Text = "";
                        employeeEditWageLabel.Text = "";
                        employeeEditGenderLabel.Text = "";
                        employeeEditStreetLabel.Text = "";

                        employeeEditConfirmButton.Hide();

                        //selfRefresh(new TabPage AddEmployeeTab);
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
                MessageBox.Show("User not Found, try again", "Error");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            if (employeeAddEmployeeID.Text.ToString() != "" && employeeAddFName.Text.ToString() != "" && employeeAddPassword.Text.ToString() != "")
            {
                try
                {
                    myConnection.Open();
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                    //Start Queries
                    myCommand.CommandText = $"insert into Employee values ({employeeAddEmployeeID.Text}," +
                                            $" '{employeeAddFName.Text}','{employeeAddLName.Text}','{employeeAddEmail.Text}'," +
                                            $"'{employeeAddGender.Text}','{employeeAddStreet.Text}', " +
                                            $"'{employeeAddCity.Text}','{employeeAddState.Text}', " +
                                            $"'{employeeAddPostal.Text}', '{EmployeeAddStartDate.Text}', " +
                                            $"{employeeAddWage.Text}, '{employeeAddPassword.Text}');";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        myReader.Close();
                        customerAddButton.Hide();
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
            else
            {
                MessageBox.Show("Please fill out EmployeeID and First Name box");
            }
        }

        private void employeeSearchDeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.employeeSearchDeletelabel.Text.ToString() != "")
                {
                    employeeDeleteButton.Show();
                    myCommand.CommandText = $"Select * from Employee as E where E.EmployeeID = {employeeSearchDeletelabel.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        employeeDeleteIDlabel.Text = myReader["EmployeeID"].ToString();
                        employeeDeleteNamelabel.Text = myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim();
                        employeeDeleteStartDatelabel.Text = myReader["StartDate"].ToString();
                        employeeDeleteEmailLabel.Text = myReader["Email"].ToString().Trim();
                        

                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show("User not Found, try again", "Error");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            

            int newCustomerID;
            string lastCustomerID;
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries


                try
                {
                    
                    myCommand.CommandText = "select max(CustomerID) as maxID from Customer;";
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    lastCustomerID = myReader["maxID"].ToString();
                    newCustomerID = Int32.Parse(lastCustomerID) + 1;
                    myReader.Close();


                    CustomerAddID.Text = newCustomerID.ToString();
                    customerAddButton.Show();
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

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            string planID = "1";

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                switch (customerAddAccountType.Text)
                {
                    case "Essential":
                        planID = "1";
                        break;
                    case "Extra":
                        planID = "2";
                        break;
                    case "Premium":
                        planID = "3";
                        break;
                }
                myCommand.CommandText = $"insert into Customer values ({CustomerAddID.Text}," +
                                        $" '{CustomerAddFName.Text}','{customerAddLName.Text}','{customerAddEmail.Text}'," +
                                        $"'{customerAddGender.Text}','{customerAddStreet.Text}', " +
                                        $"'{customerAddCity.Text}','{customerAddProvince.Text}', " +
                                        $"'{customerAddPostal.Text}', '{customerAddCreationDate.Text}', " +
                                        $"'{customerAddExpiryDate.Text}', '{customerAddCreditCard.Text}', {planID}," +
                                        $" '{customerAddPassword.Text}', 0 );";
                if (CustomerAddID.Text.ToString() != "") {
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
                    //End Queries
                }
                else
                {
                    MessageBox.Show("Either PlanID or CustomerID or Customer Name might be missing, Try again");
                }
                MessageBox.Show("Customer Succesfully Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void customerEditSearchButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            string planID = "1";

            

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.customerEditSearchID.Text.ToString() != "")
                {

                    myCommand.CommandText = $"Select * from Customer as C where C.CustomerID = {customerEditSearchID.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        customerEditID.Text = myReader["CustomerID"].ToString().Trim();
                        customerEditFName.Text = myReader["FName"].ToString().Trim();
                        customerEditLName.Text = myReader["LName"].ToString().Trim();
                        customerEditEmail.Text = myReader["Email"].ToString().Trim();
                        customerEditPassword.Text = myReader["Passwords"].ToString().Trim();
                        customerEditProvince.Text = myReader["Province"].ToString().Trim();
                        customerEditCity.Text = myReader["City"].ToString().Trim();
                        customerEditPostal.Text = myReader["ZipCode"].ToString().Trim();
                        customerEditGender.Text = myReader["Gender"].ToString().Trim();
                        customerEditStreet.Text = myReader["Street"].ToString().Trim();

                        switch (myReader["PlanID"].ToString().Trim())
                        {
                            case "1":
                                planID = "Essential";
                                break;
                            case "2":
                                planID = "Extra";
                                break;
                            case "3":
                                planID = "Premium";
                                break;
                            case "4":
                                planID = "Premium";
                                break;
                        }
                        customerEditAccountType.Text = planID;

                        customerEditConfirmButton.Show();

                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show("User not Found, try again", "Error");
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

        private void customerEditConfirmButton_Click(object sender, EventArgs e)
        {

            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            string planID = "1";
            switch (customerEditAccountType.Text)
            {
                case "Essential":
                    planID = "1";
                    break;
                case "Extra":
                    planID = "2";
                    break;
                case "Premium":
                    planID = "3";
                    break;
            }

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                myCommand.CommandText = $"UPDATE Customer " +
                                        $"SET CustomerID = {customerEditID.Text}, FName = '{customerEditFName.Text}', " +
                                        $"LName = '{customerEditLName.Text}', Email = '{customerEditEmail.Text}'," +
                                        $" Gender = '{customerEditGender.Text}', Street = '{customerEditStreet.Text}'," +
                                        $" City = '{customerEditCity.Text}', Province = '{customerEditProvince.Text}', " +
                                        $"ZipCode = '{customerEditPostal.Text}', PlanID = {planID}, " +
                                        $"Passwords = '{customerEditPassword.Text}' WHERE CustomerID = {customerEditID.Text}";
                if (customerEditID.Text.ToString() != "")
                {
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        myReader.Close();
                        MessageBox.Show("Edit Success");

                        // Re-usable code section:
                        customerEditSearchID.Text = "";
                        customerEditID.Text = "";
                        customerEditFName.Text = "";
                        customerEditLName.Text = "";
                        customerEditEmail.Text = "";
                        customerEditPassword.Text = "";
                        customerEditProvince.Text = "";
                        customerEditCity.Text = "";
                        customerEditPostal.Text = "";
                        customerEditGender.Text = "";
                        customerEditStreet.Text = "";
                        employeeEditStreetLabel.Text = "";

                        //
                        customerEditConfirmButton.Hide();

                        //selfRefresh(new TabPage AddEmployeeTab);
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
                MessageBox.Show("User not Found, try again", "Error");
            }
        }

        private void DeleteCustomerTab_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            customerDeleteID.Text = "";
            customerDeleteName.Text = "";
            customerDeleteAccountCreation.Text = "";
            customerDeleteEmail.Text = "";
            customerDeletePlanType.Text = "";
            //
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.customerDeleteSearchID.Text.ToString() != "")
                {
                    
                    myCommand.CommandText = $"Select * from Customer as C where C.CustomerID = {this.customerDeleteSearchID.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        customerDeleteID.Text = myReader["CustomerID"].ToString();
                        customerDeleteName.Text = myReader["FName"].ToString().Trim() + " " + myReader["LName"].ToString().Trim();
                        customerDeleteAccountCreation.Text = myReader["CreationDate"].ToString();
                        customerDeleteEmail.Text = myReader["Email"].ToString().Trim();
                        customerDeletePlanType.Text = myReader["PlanID"].ToString();
                        


                        myReader.Close();
                        customerDeleteButton.Show();
                    }
                    catch (Exception e3)
                    {
                        employeeDeleteButton.Hide();
                        MessageBox.Show("User not found", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert ID to attempt delete");
                    customerDeleteButton.Hide();
                }
                //End Queries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void employeeDeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.employeeDeleteIDlabel.Text.ToString() != "")
                {
                    //employeeDeleteButton.Show();
                    myCommand.CommandText = $"Delete from Employee where Employee.EmployeeID = {employeeDeleteIDlabel.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        myReader.Close();

                        // Re-use codee here
                        //  - Clear out fields,
                        //  - refresh tab,
                        //  - Hide delete button
                        employeeDeleteIDlabel.Text = "";
                        employeeDeleteNamelabel.Text = "";
                        employeeDeleteStartDatelabel.Text = "";
                        employeeDeleteEmailLabel.Text = "";
                        employeeSearchDeletelabel.Text = "";
                        DeleteEmployeetab.Refresh();
                        employeeDeleteButton.Hide();
                        MessageBox.Show("Deletion Succesful");

                        //
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString());
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
                MessageBox.Show("User not Found, try again", "Error");
            }
        }

        private void customerDeleteButton_Click(object sender, EventArgs e)
        {

            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries
                //MessageBox.Show($"Looking for Employee: {this.idSearch.Text}");

                if (this.customerDeleteID.Text.ToString() != "")
                {
                    myCommand.CommandText = $"Delete from Customer where Customer.CustomerID = {this.customerDeleteID.Text}";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        myReader.Close();

                        //  Re-use codee here
                        //  - Clear out fields,
                        //  - refresh tab,
                        //  - Hide delete button
                        customerDeleteID.Text = "";
                        customerDeleteName.Text = "";
                        customerDeleteAccountCreation.Text = "";
                        customerDeleteEmail.Text = "";
                        customerDeletePlanType.Text = "";
                        customerDeleteSearchID.Text = "";
                        customerDeleteButton.Hide();
                        MessageBox.Show("Deletion Succesful");


                        //
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString());
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server = SUBBIESLAPTOP\\SQLEXPRESS;Database=BLOCKBUSTER;Trusted_connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);



            int newCustomerID;
            string lastCustomerID;
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //Start Queries


                try
                {

                    myCommand.CommandText = "select max(EmployeeID) as maxID from Employee;";
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    lastCustomerID = myReader["maxID"].ToString();
                    newCustomerID = Int32.Parse(lastCustomerID) + 1;
                    myReader.Close();


                    employeeAddEmployeeID.Text = newCustomerID.ToString();
                    employeeAddButton.Show();
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
    }
}
