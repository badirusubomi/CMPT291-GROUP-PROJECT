using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT291_GROUP_PROJECT
{
    public class User
    {

        //properties
        public int _ID;
        public string _Fname;
        public string _Lname;
        public string _DOB;
        public string _address;
        //private  List<string> _phoneNumbers;
        public string _email;
        public string _query;

        public User()
        {



        }

        public string query
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public string Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                _Fname = value;
            }
        }
        public string Lname
        {
            get { return _Lname; }
            set { _Lname = value; }
        }
        public string DoB
        {
            get { return _DOB; }
            set
            {
                _DOB = value;
            }   
        }
        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
    }
}
